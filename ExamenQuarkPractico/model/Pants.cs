using System;
using System.Collections.Generic;
using System.Text;
using ExamenQuarkPractico.Enums;

namespace ExamenQuarkPractico.model
{
    public class Pants : Clothes, IPriceable 
    {
        private PantsFitType _type;

        public PantsFitType Type { get => _type; private set => _type = value; }

        public Pants(PantsFitType type, ClothesQuality quality, float unitPrice)
        {
            _type = type;
            Quality = quality;
            UnitPrice = unitPrice;
        }

        public override float Price(float pricing = 0f)
        {
            pricing = UnitPrice;

            if (_type == PantsFitType.skinnyFit)
                UnitPrice *= 0.88f;

            pricing = base.Price(pricing);

            return pricing;
        }
    }
}
