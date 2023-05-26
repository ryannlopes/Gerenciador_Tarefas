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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

            MenuEscolhido = "";
        }

        private string MenuEscolhido;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MenuEscolhido = "Responsavel";

            Login loginscreen = new Login(MenuEscolhido);
            loginscreen.Show();
            this.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MenuEscolhido = "Filho";

            Login loginscreen = new Login(MenuEscolhido);
            loginscreen.Show();
            this.Hide();
        }
    }
}
