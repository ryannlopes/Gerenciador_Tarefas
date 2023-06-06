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
            MenuEscolhidoTxt.Text = "Registro - "+receivedVariable;

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Login login = new Login(receivedVariable);
           // Login.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
