using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemLogin
{
    public partial class F_SystemLogin : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public F_SystemLogin()
        {
            InitializeComponent();
            connection.ConnectionString = @"Data Source=DESKTOP-DJRN7DM\SQL2019;Initial Catalog=LOGIN;Integrated Security=True";
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
            //Abrir banco de dados
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Authentication";
            SqlDataReader data_reader = command.ExecuteReader();

            if (data_reader.Read())
            {
                if (tb_login.Text.Equals(data_reader["username"].ToString()) && tb_password.Text.Equals(data_reader["password"].ToString()))
                {
                    MessageBox.Show("Login efetuado com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuário e senha não confere.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Fechar banco de dados
            connection.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
