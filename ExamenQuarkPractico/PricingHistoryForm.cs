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
    public partial class PricingHistoryForm : Form
    {
        public PricingHistoryForm(List<Pricing> pricings)
        {
            InitializeComponent();
            PrintPricings(pricings);
        }

        private void PrintPricings(List<Pricing> pricings)
        {
            foreach (var pricing in pricings)
            {
                pricingID.Text += $"\n{pricing.Id}";
                pricingDate.Text += $"\n{pricing.PricingDate}";
                pricingSeller.Text += $"\n{pricing.SellerId}";
                string clothe = pricing.Clothe == ClothesType.shirt ? "Camisa" : "Pantalon";
                pricingClothe.Text += $"\n{clothe}";
                pricingQty.Text += $"\n{pricing.Quantity}";
                histPrice.Text += $"\n${pricing.CurrentPricing}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
