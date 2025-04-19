using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace TLoginPrj
{
    public partial class TFPassword : Form
    {

        private string emailUsuario = string.Empty;
        public TFPassword()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            
            LbLMail.Show();
            TxtEmail.Show();
            BtnCodigo.Show();

            
            LblCodigo.Hide();
            TxtCodigo.Hide();
            BtnConfirmC.Hide();
            lblNewpss.Hide();
            TxtNPass.Hide();
            BtnConfirmP.Hide();

           
            TxtEmail.Text = "";
            TxtCodigo.Text = "";
            TxtNPass.Text = "";

            
            BtnCodigo.Location = new Point(380, 185);
        }

        private void BtnCodigo_Click(object sender, EventArgs e)
        {
            emailUsuario = TxtEmail.Text.Trim();
            if (string.IsNullOrEmpty(emailUsuario))
            {
                MessageBox.Show("Digite seu e-mail.");
                return;
            }

            string caminhoDoBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "users.db");
            string conexaoString = "Data Source=" + caminhoDoBanco;

            using (var conexao = new SQLiteConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    
                    string verificarEmailSql = "SELECT COUNT(*) FROM users WHERE Email = @Email";
                    using (var cmdVerificar = new SQLiteCommand(verificarEmailSql, conexao))
                    {
                        cmdVerificar.Parameters.AddWithValue("@Email", emailUsuario);
                        long count = (long)cmdVerificar.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("E-mail não encontrado.");
                            return;
                        }
                    }

                    
                    string codigo = new Random().Next(100000, 999999).ToString();
                    string dataExpiracao = DateTime.Now.AddMinutes(10).ToString("yyyy-MM-dd HH:mm:ss");

                    
                    string atualizarSql = "UPDATE users SET CodigoRecuperacao = @Codigo, DataExpiracao = @Expiracao WHERE Email = @Email";
                    using (var cmdAtualizar = new SQLiteCommand(atualizarSql, conexao))
                    {
                        cmdAtualizar.Parameters.AddWithValue("@Codigo", codigo);
                        cmdAtualizar.Parameters.AddWithValue("@Expiracao", dataExpiracao);
                        cmdAtualizar.Parameters.AddWithValue("@Email", emailUsuario);
                        cmdAtualizar.ExecuteNonQuery();
                    }

                    
                    EnviarEmail(emailUsuario, codigo);

                   
                    MessageBox.Show("Código enviado! Verifique seu e-mail.");

                    
                    BtnConfirmC.Show();
                    LblCodigo.Show();
                    TxtCodigo.Show();
                    BtnCodigo.Hide();
                    LbLMail.Hide();
                    TxtEmail.Hide();
                    BtnConfirmC.Location = new Point(380, 185);
                    TxtCodigo.Location = new Point(380, 160);
                    LblCodigo.Location = new Point(338, 162);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao processar a solicitação: " + ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        private void BtnConfirmC_Click(object sender, EventArgs e)
        {
            string codigoDigitado = TxtCodigo.Text.Trim();
            string caminhoDoBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "users.db");
            string conexaoString = "Data Source=" + caminhoDoBanco;

            using (var conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

                string sql = "SELECT CodigoRecuperacao, DataExpiracao FROM users WHERE Email = @Email";
                using (var cmd = new SQLiteCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Email", emailUsuario);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string codigoBD = reader["CodigoRecuperacao"]?.ToString() ?? "";
                            string dataExpiracao = reader["DataExpiracao"]?.ToString() ?? "";

                            DateTime expiracao = DateTime.Parse(dataExpiracao);

                            if (codigoBD != codigoDigitado)
                            {
                                MessageBox.Show("Código incorreto.");
                                return;
                            }

                            if (DateTime.Now > expiracao)
                            {
                                MessageBox.Show("Código expirado. Solicite um novo.");
                                return;
                            }

                           
                            MessageBox.Show("Código verificado com sucesso! Agora você pode redefinir sua senha.");

                            
                            BtnConfirmC.Hide();
                            LblCodigo.Hide();
                            TxtCodigo.Hide();
                            BtnConfirmP.Show();
                            TxtNPass.Show();
                            lblNewpss.Show();
                            BtnConfirmP.Location = new Point(380, 185);
                            TxtNPass.Location = new Point(380, 160);
                            lblNewpss.Location = new Point(290, 162);
                        }
                        else
                        {
                            MessageBox.Show("E-mail não encontrado.");
                        }
                    }
                }
            }
        }

        private void BtnConfirmP_Click(object sender, EventArgs e)
        {
            string novaSenha = TxtNPass.Text.Trim();

            if (string.IsNullOrEmpty(novaSenha))
            {
                MessageBox.Show("Digite uma nova senha.");
                return;
            }

            string caminhoDoBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "users.db");
            string conexaoString = "Data Source=" + caminhoDoBanco;

            using (var conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"UPDATE users
                               SET PassWord = @SenhaNova,
                                   CodigoRecuperacao = NULL,
                                   DataExpiracao = NULL
                               WHERE Email = @Email";

                using (var cmd = new SQLiteCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@SenhaNova", novaSenha);
                    cmd.Parameters.AddWithValue("@Email", emailUsuario);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Senha redefinida com sucesso!");
                        this.Close(); 
                        TLogin tLogin = new TLogin();
                        tLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao redefinir senha.");
                    }
                }

                conexao.Close();
            }
        }

        public void EnviarEmail(string para, string codigo)
        {
            try
            {
                
                var mensagem = new MimeMessage();
                mensagem.From.Add(new MailboxAddress("Suporte Técnico", "SupTecTForm@gmail.com"));
                mensagem.To.Add(new MailboxAddress("", para)); 
                mensagem.Subject = "Código de Recuperação de Senha";
                mensagem.Body = new TextPart("plain") 
                {
                    Text = $"Seu código de recuperação é: {codigo}"
                };

                
                using (var client = new SmtpClient())
                {
                    
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);

                    client.Authenticate("suptectform@gmail.com", "fwjx nfmb nkxu mntp");

                    
                    client.Send(mensagem);
                    client.Disconnect(true); 
                }

                MessageBox.Show("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            }
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}