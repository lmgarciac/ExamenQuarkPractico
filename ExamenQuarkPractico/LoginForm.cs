using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenQuarkPractico.controller;

namespace ExamenQuarkPractico
{
    public partial class LoginForm : Form
    {
        LoginController _loginController = new LoginController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PricingForm pricing = new PricingForm(_loginController.Login(sellerName.Text, sellerSurname.Text, sellerCode.Text));
            pricing.Show();
            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
