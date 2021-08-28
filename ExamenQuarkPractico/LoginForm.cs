using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenQuarkPractico.model;

namespace ExamenQuarkPractico
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sellerCodeNumeric = 0;
            int.TryParse(sellerCode.Text, out sellerCodeNumeric);

            Seller seller = new Seller(sellerName.Text, sellerSurname.Text, sellerCodeNumeric);
            PricingForm pricing = new PricingForm(seller);
            pricing.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sellerCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
