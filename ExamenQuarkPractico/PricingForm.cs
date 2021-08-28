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
using ExamenQuarkPractico.model;

namespace ExamenQuarkPractico
{
    public partial class PricingForm : Form
    {
        private Seller _currentSeller;

        public PricingForm(Seller seller)
        {
            InitializeComponent();
            _currentSeller = seller;
            sellerName.Text = $"{seller.Name} {seller.Surname}";
            sellerCode.Text = $"{seller.Id}";
            shopName.Text = Shop.Name;
            shopAddress.Text = Shop.Address;

            int stockQty = 0;
            Clothes.stock.TryGetValue(ClothesType.shirt, out stockQty);
            stockAvailable.Text = stockQty.ToString();
        }

        private void cotizar_Click(object sender, EventArgs e)
        {
            RadioButton clothesTypeSelection = containerClothesType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            ClothesType clothesType = (ClothesType)Enum.Parse(typeof(ClothesType), clothesTypeSelection.Name, true);

            RadioButton clothesQualitySelection = containerClothesQuality.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            ClothesQuality clothesQuality = (ClothesQuality)Enum.Parse(typeof(ClothesQuality), clothesQualitySelection.Name, true);

            NeckType neckType = NeckType.none;
            SleeveType sleeveType = SleeveType.none;
            PantsFitType pantsFitType = PantsFitType.none;

            if (clothesType == ClothesType.shirt)
            {
                neckType = maoNeck.Checked ? NeckType.maoNeck : NeckType.regularNeck;
                sleeveType = shortSleeve.Checked ? SleeveType.shortSleeve : SleeveType.longSleeve;
            }

            if (clothesType == ClothesType.pants)
            {
                pantsFitType = skinnyFit.Checked ? PantsFitType.skinnyFit : PantsFitType.regularFit;
            }

            PriceController priceController = new PriceController();

            float.TryParse(tbUnitPrice.Text, out float unitPriceValue);
            int.TryParse(tbQuantity.Text, out int quantityNumeric);

            if (quantityNumeric == 0)
            {
                quantityNumeric = 1;
                tbQuantity.Text = quantityNumeric.ToString();
            }

            float finalPriceNumeric = priceController.CalculatePrice(clothesType, clothesQuality, neckType, sleeveType, pantsFitType, unitPriceValue) * quantityNumeric;

            finalPrice.Text = finalPriceNumeric.ToString();

            int pricingid = _currentSeller.Pricings.Count + 1;
            Pricing _currentPricing = new Pricing(pricingid, DateTime.Now, _currentSeller.Id, clothesType, quantityNumeric, finalPriceNumeric);

            _currentSeller.Pricings.Add(_currentPricing);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void shirt_CheckedChanged(object sender, EventArgs e)
        {
            skinnyFit.Enabled = false;
            shortSleeve.Enabled = true;
            maoNeck.Enabled = true;

            int stockQty = 0;
            Clothes.stock.TryGetValue(ClothesType.shirt, out stockQty);
            stockAvailable.Text = stockQty.ToString();
        }

        private void pants_CheckedChanged(object sender, EventArgs e)
        {
            skinnyFit.Enabled = true;
            shortSleeve.Enabled = false;
            maoNeck.Enabled = false;

            int stockQty = 0;
            Clothes.stock.TryGetValue(ClothesType.pants, out stockQty);
            stockAvailable.Text = stockQty.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var pricingHistory = new PricingHistoryForm(_currentSeller.Pricings);
            pricingHistory.ShowDialog();
        }
    }
}
