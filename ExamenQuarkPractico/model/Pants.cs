using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenQuarkPractico.model
{
    class Pants : Clothes, ICotizable
    {
        private PantsFitType _type;

        public Pants(PantsFitType type, ClothesQuality quality, float unitPrice)
        {
            _type = type;
            _quality = quality;
            _unitPrice = unitPrice;
        }

        public override float Price(float pricing = 0f)
        {
            pricing = _unitPrice;

            if (_type == PantsFitType.skinnyFit)
                _unitPrice *= 0.88f;

            pricing = base.Price(pricing);

            return pricing;
        }
    }
}
