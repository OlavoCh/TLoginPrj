using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TLoginPrj
{
    public partial class TLogin : Form
    {
        public TLogin()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
            BtnRes.Show();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            TResg resg = new TResg();
            this.Hide();
            resg.Show();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "users.db");

            string conexaoString = "Data Source=" + caminho;

            using (var conexao = new SQLiteConnection(conexaoString))
            {
                conexao.Open();
                string sql = "SELECT COUNT(*) FROM users WHERE User = @User AND PassWord = @PassWord AND Email = @Email";

                using (var cmd = new SQLiteCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@User", TxtUser.Text);
                    cmd.Parameters.AddWithValue("@PassWord", TxtPass.Text);
                    cmd.Parameters.AddWithValue("@Email", TxtMail.Text);

                    try
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            T1 t1 = new T1();
                            this.Hide();
                            t1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            BtnLogin.Location = new Point(379, 245);
                            label4.Location = new Point(364, 271);
                            BtnRes.Location = new Point(379, 289);
                            label5.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao realizar login: " + ex.Message);
                    }
                }

                conexao.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            TFPassword newpass = new TFPassword();
            this.Hide();
            newpass.Show();
        }

        private void TLogin_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            TFPassword tFPassword = new TFPassword();
            this.Hide();
            tFPassword.Show();
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
