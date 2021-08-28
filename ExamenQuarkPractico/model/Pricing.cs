using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenQuarkPractico.model
{
    public class Pricing
    {
        private int _id;
        private DateTime _pricingDate;
        private int _sellerId;
        private ClothesType _clothe;
        private int _quantity;
        private float _currentPricing;

        public Pricing(int id, DateTime pricingDate, int sellerId, ClothesType clothe, int quantity, float pricing)
        {
            Id = id;
            PricingDate = pricingDate;
            SellerId = sellerId;
            Clothe = clothe;
            Quantity = quantity;
            CurrentPricing = pricing;
        }

        public int Id { get => _id; set => _id = value; }
        public DateTime PricingDate { get => _pricingDate; set => _pricingDate = value; }
        public int SellerId { get => _sellerId; set => _sellerId = value; }
        public ClothesType Clothe { get => _clothe; set => _clothe = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public float CurrentPricing { get => _currentPricing; set => _currentPricing = value; }
    }
}
