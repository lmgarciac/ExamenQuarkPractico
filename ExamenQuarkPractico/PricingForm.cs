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
        PricingController _pricingController;

        public PricingForm(Seller seller)
        {
            InitializeComponent();
            _pricingController = new PricingController(seller);
            InitializeTextFields(seller);
        }

        private void InitializeTextFields(Seller seller)
        {
            sellerName.Text = $"{seller.Name} {seller.Surname}";
            sellerCode.Text = $"{seller.Id}";
            shopName.Text = Shop.Name;
            shopAddress.Text = Shop.Address;
            stockAvailable.Text = _pricingController.GetStock(ClothesType.shirt, ClothesQuality.standardQuality, SleeveType.none, NeckType.none).ToString();
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

            float.TryParse(tbUnitPrice.Text, out float unitPriceValue);
            int.TryParse(tbQuantity.Text, out int quantityNumeric);

            if (quantityNumeric == 0)
            {
                quantityNumeric = 1;
                tbQuantity.Text = quantityNumeric.ToString();
            }

            float finalPriceNumeric = _pricingController.CalculatePrice(clothesType, clothesQuality, neckType, sleeveType, pantsFitType, unitPriceValue, quantityNumeric);

            finalPrice.Text = finalPriceNumeric.ToString();
        }

        private void shirt_CheckedChanged(object sender, EventArgs e)
        {
            skinnyFit.Enabled = false;
            skinnyFit.Checked = false;
            shortSleeve.Enabled = true;
            maoNeck.Enabled = true;

            RadioButton clothesQualitySelection = containerClothesQuality.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            ClothesQuality clothesQuality = (ClothesQuality)Enum.Parse(typeof(ClothesQuality), clothesQualitySelection.Name, true);

            int stockQty = _pricingController.GetStock(ClothesType.shirt, clothesQuality, SleeveType.none, NeckType.none);
            stockAvailable.Text = stockQty.ToString();
        }

        private void pants_CheckedChanged(object sender, EventArgs e)
        {
            skinnyFit.Enabled = true;
            shortSleeve.Enabled = false;
            maoNeck.Enabled = false;
            shortSleeve.Checked = false;
            maoNeck.Checked = false;

            RadioButton clothesQualitySelection = containerClothesQuality.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            ClothesQuality clothesQuality = (ClothesQuality)Enum.Parse(typeof(ClothesQuality), clothesQualitySelection.Name, true);

            int stockQty = _pricingController.GetStock(ClothesType.pants, clothesQuality, PantsFitType.none);
            stockAvailable.Text = stockQty.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var pricingHistory = new PricingHistoryForm(_pricingController.CurrentSeller.Pricings);
            pricingHistory.ShowDialog();
        }

        private void shortSleeve_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clothesQualitySelection = containerClothesQuality.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            ClothesQuality clothesQuality = (ClothesQuality)Enum.Parse(typeof(ClothesQuality), clothesQualitySelection.Name, true);

            SleeveType sleeveType = SleeveType.longSleeve;
            if (shortSleeve.Checked)
                sleeveType = SleeveType.shortSleeve;
            else
                sleeveType = SleeveType.none;

            NeckType neckType = NeckType.regularNeck;
            if (maoNeck.Checked)
                neckType = NeckType.maoNeck;
            else
                neckType = NeckType.none;

            int stockQty = _pricingController.GetStock(ClothesType.shirt, clothesQuality, sleeveType, neckType);
            stockAvailable.Text = stockQty.ToString();
        }

        private void maoNeck_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clothesQualitySelection = containerClothesQuality.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            ClothesQuality clothesQuality = (ClothesQuality)Enum.Parse(typeof(ClothesQuality), clothesQualitySelection.Name, true);

            NeckType neckType = NeckType.regularNeck;
            if (maoNeck.Checked)
                neckType = NeckType.maoNeck;
            else
                neckType = NeckType.none;

            SleeveType sleeveType = SleeveType.longSleeve;
            if (shortSleeve.Checked)
                sleeveType = SleeveType.shortSleeve;
            else
                sleeveType = SleeveType.none;

            int stockQty = _pricingController.GetStock(ClothesType.shirt, clothesQuality, sleeveType, neckType);
            stockAvailable.Text = stockQty.ToString();
        }

        private void tbUnitPrice_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbUnitPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solo números", "Error");
                tbUnitPrice.Text = tbUnitPrice.Text.Remove(tbUnitPrice.Text.Length - 1);
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solo números", "Error");
                tbQuantity.Text = tbQuantity.Text.Remove(tbQuantity.Text.Length - 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void skinnyFit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void standardQuality_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void premiumQuality_CheckedChanged(object sender, EventArgs e)
        {

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

    }
}
