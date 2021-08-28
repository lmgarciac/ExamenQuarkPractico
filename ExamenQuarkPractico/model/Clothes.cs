using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ExamenQuarkPractico.Enums;

namespace ExamenQuarkPractico.model
{
    public abstract class Clothes : IPriceable
    {
        public ClothesQuality _quality;
        private float _unitPrice;

        public ClothesQuality Quality { get => _quality; set => _quality = value; }
        protected float UnitPrice { get => _unitPrice; set => _unitPrice = value; }

        public virtual float Price(float pricing)
        {
            if (Quality == ClothesQuality.premiumQuality)
                pricing *= 1.3f;

            return pricing;
        }

    }
}
