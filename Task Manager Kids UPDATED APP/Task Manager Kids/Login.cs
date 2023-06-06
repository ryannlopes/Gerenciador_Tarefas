using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Task_Manager_Kids
{
    public partial class Login : Form
    {
        private string receivedVariable;
        public Login(string MenuEscolhido)
        {

            receivedVariable = MenuEscolhido;

            InitializeComponent();
            PasswordTxt.UseSystemPasswordChar = true;
            MenuEscolhidoTxt.Text = receivedVariable;
        }

        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = GetConnection();
            
            connection.Open();
            string query;
            int count;
            MySqlCommand cmd = new MySqlCommand();

            if (receivedVariable == "Filho")
            {

                try
                {
                    query = "SELECT COUNT(*) FROM KID WHERE USER = @User AND PASSWORD = @Password";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@User", UserTxt.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTxt.Text);
                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Login válido, faça o redirecionamento ou execute as ações desejadas
                        label3.Text = "Login válido. Redirecionando...";
                        MenuPrincipalFilho menuprincipal = new MenuPrincipalFilho();
                        menuprincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Login inválido, trate de acordo (exibindo mensagem de erro, limpando campos, etc.)
                        label3.Text = "Login inválido. Por favor, tente novamente.";
                        UserTxt.BorderColor = Color.Red;
                        PasswordTxt.BorderColor = Color.Red;
                    }
                }

                catch (Exception ex)

                {
                    label2.Text = "Erro durante a validação do login: " + ex.Message;
                }
                finally
                {
                    connection.Close();
                }

            }
            else if (receivedVariable == "Responsavel")
            {
                try
                {
                    query = "SELECT COUNT(*) FROM PARENT WHERE USER = @User AND PASSWORD = @Password";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@User", UserTxt.Text);
                    cmd.Parameters.AddWithValue("@Password", PasswordTxt.Text);
                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Login válido, faça o redirecionamento ou execute as ações desejadas
                        label3.Text = "Login válido. Redirecionando...";
                        MenuPrincipalResponsavel menuprincipalresponsavel = new MenuPrincipalResponsavel();
                        menuprincipalresponsavel.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Login inválido, trate de acordo (exibindo mensagem de erro, limpando campos, etc.)
                        label3.Text = "Login inválido. Por favor, tente novamente.";
                        UserTxt.BorderColor = Color.Red;
                        PasswordTxt.BorderColor = Color.Red;
                    }
                }

                catch (Exception ex)

                {
                    label2.Text = "Erro durante a validação do login: " + ex.Message;
                }
                finally
                {
                    connection.Close();
                }


            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(PasswordTxt.UseSystemPasswordChar == false){
                PasswordTxt.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTxt.UseSystemPasswordChar = false;
            }
            
        }

        private void UserTxt_TextChanged(object sender, EventArgs e)
        {
            UserTxt.BorderColor = Color.White;
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            PasswordTxt.BorderColor = Color.White;
        }

        public MySqlConnection GetConnection()
        {
            string host = "localhost";
            string usuario = "root";
            string senha = "";
            string banco = "taskmanagerkids";
            string connectionString = $"server={host};database={banco};uid={usuario};password={senha}";

            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = GetConnection();

            try
            {
                connection.Open();
                label2.Text = "Connected";
            }
            catch (MySqlException ex)
            {
                label2.Text = "failed";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
 
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            TelaInicial telainicial = new TelaInicial();
            telainicial.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(receivedVariable);
            registro.Show();
            this.Hide();
        }
    }
}
