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

namespace TLoginPrj
{
    public partial class TRPassword : Form
    {
        public TRPassword()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BtnReturn.Show();
        }

        private void BtnResg_Click(object sender, EventArgs e)
        {
            string usuario = TxtUser.Text;
            string senhaAntiga = TxtOldPass.Text;
            string senhaNova = TxtPass.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senhaAntiga) || string.IsNullOrWhiteSpace(senhaNova))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string caminhoDoBanco = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "users.db");
            string conexaoString = "Data Source=" + caminhoDoBanco;

            using (var conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();

               
                string verificarSenhaSql = "SELECT COUNT(*) FROM users WHERE User = @User AND PassWord = @PassWord";
                using (var cmdVerificar = new SQLiteCommand(verificarSenhaSql, conexao))
                {
                    cmdVerificar.Parameters.AddWithValue("@User", usuario);
                    cmdVerificar.Parameters.AddWithValue("@PassWord", senhaAntiga);

                    int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("Usuário ou senha antiga incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

               
                string atualizarSenhaSql = "UPDATE users SET PassWord = @PassWord WHERE User = @User";
                using (var cmdAtualizar = new SQLiteCommand(atualizarSenhaSql, conexao))
                {
                    cmdAtualizar.Parameters.AddWithValue("@PassWord", senhaNova);
                    cmdAtualizar.Parameters.AddWithValue("@User", usuario);

                    try
                    {
                        cmdAtualizar.ExecuteNonQuery();
                        MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TLogin login = new TLogin();
                        this.Hide();
                        login.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao redefinir senha: " + ex.Message);
                    }
                }
                conexao.Close();
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            TLogin login = new TLogin();
            this.Hide();
            login.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtOldPass.PasswordChar == '\0')
            {
                TxtOldPass.PasswordChar = '*'; 
            }
            else

                TxtOldPass.PasswordChar = '\0';  

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtPass.PasswordChar == '\0')
            {
                TxtPass.PasswordChar = '*';  
            }
            else
            {
                TxtPass.PasswordChar = '\0';  
            }
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
