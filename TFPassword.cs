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
            InicializarFormulario(); // Chama o método para inicializar o formulário
        }

        private void InicializarFormulario()
        {
            // Mostra os campos iniciais
            LbLMail.Show();
            TxtEmail.Show();
            BtnCodigo.Show();

            // Esconde os campos do código e nova senha
            LblCodigo.Hide();
            TxtCodigo.Hide();
            BtnConfirmC.Hide();
            lblNewpss.Hide();
            TxtNPass.Hide();
            BtnConfirmP.Hide();

            // Limpa os campos
            TxtEmail.Text = "";
            TxtCodigo.Text = "";
            TxtNPass.Text = "";

            // Redefine as posições dos controles (se necessário)
            BtnCodigo.Location = new Point(380, 185);
        }

        private void BtnCodigo_Click(object sender, EventArgs e)
        {
            emailUsuario = TxtEmail.Text.Trim(); // Armazena o e-mail na variável
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

                    // Verifica se o e-mail existe
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

                    // Gera o código de recuperação
                    string codigo = new Random().Next(100000, 999999).ToString();
                    string dataExpiracao = DateTime.Now.AddMinutes(10).ToString("yyyy-MM-dd HH:mm:ss");

                    // Salva o código no banco de dados
                    string atualizarSql = "UPDATE users SET CodigoRecuperacao = @Codigo, DataExpiracao = @Expiracao WHERE Email = @Email";
                    using (var cmdAtualizar = new SQLiteCommand(atualizarSql, conexao))
                    {
                        cmdAtualizar.Parameters.AddWithValue("@Codigo", codigo);
                        cmdAtualizar.Parameters.AddWithValue("@Expiracao", dataExpiracao);
                        cmdAtualizar.Parameters.AddWithValue("@Email", emailUsuario);
                        cmdAtualizar.ExecuteNonQuery();
                    }

                    // Chama a função para enviar o código de recuperação por e-mail
                    EnviarEmail(emailUsuario, codigo);

                    // Exibe os campos para o código de verificação
                    MessageBox.Show("Código enviado! Verifique seu e-mail.");

                    // Atualiza a visibilidade dos campos
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

                            // ✅ Código correto e dentro do prazo
                            MessageBox.Show("Código verificado com sucesso! Agora você pode redefinir sua senha.");

                            // Só aqui mostra os campos da nova senha
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
                        this.Close(); // ou redirecionar para tela de login
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
                // Cria a mensagem de e-mail
                var mensagem = new MimeMessage();
                mensagem.From.Add(new MailboxAddress("Suporte Técnico", "SupTecTForm@gmail.com"));
                mensagem.To.Add(new MailboxAddress("", para)); // Destinatário
                mensagem.Subject = "Código de Recuperação de Senha"; // Assunto
                mensagem.Body = new TextPart("plain") // Corpo do e-mail
                {
                    Text = $"Seu código de recuperação é: {codigo}"
                };

                // Configuração do cliente SMTP
                using (var client = new SmtpClient())
                {
                    // Conecta ao servidor SMTP (exemplo com Gmail)
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);

                    // Autentica com seu e-mail e senha
                    client.Authenticate("suptectform@gmail.com", "xzao trnt zgup exqd");

                    // Envia a mensagem
                    client.Send(mensagem);
                    client.Disconnect(true); // Desconecta do servidor SMTP
                }

                MessageBox.Show("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            }
        }
    }
}