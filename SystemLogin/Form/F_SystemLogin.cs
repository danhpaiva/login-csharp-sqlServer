using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemLogin
{
    public partial class F_SystemLogin : Form
    {


        public F_SystemLogin()
        {
            InitializeComponent();
        }

        private void tb_loginEnter(object sender, EventArgs e)
        {
            if (tb_login.Text.Equals(""))
            {
                tb_login.Text = "Digite seu usuário";
            }
        }

        private void tb_loginExit(object sender, EventArgs e)
        {
            if (tb_login.Text.Equals(""))
            {
                tb_login.Text = "Digite seu usuário";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            string sql = "SELECT * FROM Authentication where username = @login";
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DESKTOP-DJRN7DM\SQL2019;Initial Catalog=LOGIN;Integrated Security=True";

                //Abrir banco de dados
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@login", tb_login.Text);

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    if (tb_login.Text.Equals(reader["username"].ToString()) && tb_password.Text.Equals(reader["password"].ToString()))
                    {
                        MessageBox.Show("Login efetuado com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Usuário e senha não confere.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            finally
            {
                // Fecha o datareader
                if (reader != null)
                {
                    reader.Close();
                }

                // Fecha a conexão
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
