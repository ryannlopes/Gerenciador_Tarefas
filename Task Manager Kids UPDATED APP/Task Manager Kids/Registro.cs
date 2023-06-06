using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager_Kids
{
    public partial class Registro : Form
    {
        private string receivedVariable;
        public Registro(string MenuEscolhido)
        {
            InitializeComponent();
            receivedVariable = MenuEscolhido;
            PasswordTxt.UseSystemPasswordChar = true;
            MenuEscolhidoTxt.Text = "Registro - "+receivedVariable;

        }

        //-------------------------------------------------

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

        //-------------------------------------------------


        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (receivedVariable == "Filho")
            {

                string query = $"INSERT INTO kid (name, user, password, Score) VALUES ('{NameTxt.Text}', '{UserTxt.Text}', '{PasswordTxt.Text}', 0)";

                MySqlConnection connection = GetConnection();

                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();

                    label6.Text = "Registrado";
                }
                catch (MySqlException ex)
                {
                    label6.Text = "failed";
                }
            }
            else if(receivedVariable == "Responsavel")
            {
                string query = $"INSERT INTO parent (name, user, password) VALUES ('{NameTxt.Text}', '{UserTxt.Text}', '{PasswordTxt.Text}')";

                MySqlConnection connection = GetConnection();

                try
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();

                    label6.Text = "Registrado";
                }
                catch (MySqlException ex)
                {
                    label6.Text = "failed";
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login login = new Login(receivedVariable);
            login.Show();
            this.Hide();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordTxt.UseSystemPasswordChar == false)
            {
                PasswordTxt.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTxt.UseSystemPasswordChar = false;
            }
        }
    }
}
