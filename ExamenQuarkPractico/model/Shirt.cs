using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenQuarkPractico.model
{
    class Shirt : Clothes, ICotizable
    {
        private NeckType _neckType;
        private SleeveType _sleeveType;

        public Shirt(NeckType neckType, SleeveType sleeveType, ClothesQuality quality, float unitPrice)
        {
            _neckType = neckType;
            _sleeveType = sleeveType;
            _quality = quality;
            _unitPrice = unitPrice;
        }

        public override float Price(float pricing = 0f)
        {
            pricing = _unitPrice;

            if (_sleeveType == SleeveType.shortSleeve)
                pricing *= 0.9f;
            if (_neckType == NeckType.maoNeck)
                pricing *= 1.03f;

            pricing = base.Price(pricing);

            return pricing;
        }
    }
}
