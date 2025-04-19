using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using static TLoginPrj.TLogin;

namespace TLoginPrj
{
    public partial class TResg : Form
    {
        public TResg()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BtnReturn.Show();
            label4.ForeColor = Color.Black;
        }

        private void BtnResg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtPass.Text) && !string.IsNullOrWhiteSpace(TxtUser.Text))
            {
                string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "users.db");
                string conexaoStr = "Data Source=" + caminho;

                try
                {
                    using (var conexao = new SQLiteConnection(conexaoStr))
                    {
                        conexao.Open();
                        string sql = @"INSERT INTO users(User, PassWord, Email) VALUES(@User, @PassWord, @Email);";
                        using (var cmd = new SQLiteCommand(sql, conexao))
                        {
                            cmd.Parameters.AddWithValue("@User", TxtUser.Text);
                            cmd.Parameters.AddWithValue("@PassWord", TxtPass.Text);
                            cmd.Parameters.AddWithValue("@Email", TxtMail.Text);
                            cmd.ExecuteNonQuery();
                        }
                        conexao.Close();
                    }
                    MessageBox.Show("Registration Successful", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TLogin login = new TLogin();
                    this.Hide();
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Registration Error - Preencha os campos obrigatórios", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            TLogin login = new TLogin();
            this.Hide();
            login.Show();
        }

        private void TResg_Load(object sender, EventArgs e)
        {
            string pasta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
            string caminhoDoBanco = Path.Combine(pasta, "users.db");

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            if (!File.Exists(caminhoDoBanco))
                SQLiteConnection.CreateFile(caminhoDoBanco);

            using (var conexao = new SQLiteConnection("Data Source=" + caminhoDoBanco))
            {
                conexao.Open();

                
                string checkTableSql = "SELECT count(name) FROM sqlite_master WHERE type='table' AND name='users';";
                using (var cmdCheckTable = new SQLiteCommand(checkTableSql, conexao))
                {
                    long tableExists = (long)cmdCheckTable.ExecuteScalar();
                    if (tableExists == 0)
                    {
                        
                        string createTableSql = @"CREATE TABLE IF NOT EXISTS users(
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            User TEXT NOT NULL UNIQUE,
                                            PassWord TEXT NOT NULL,
                                            Email TEXT NOT NULL UNIQUE,
                                            CodigoRecuperacao TEXT,
                                            DataExpiracao TEXT
                                        );";
                        using (var cmd = new SQLiteCommand(createTableSql, conexao))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                conexao.Close();
            }
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
