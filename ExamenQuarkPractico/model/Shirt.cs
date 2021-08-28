using System;
using System.Collections.Generic;
using System.Text;
using ExamenQuarkPractico.Enums;

namespace ExamenQuarkPractico.model
{
    public class Shirt : Clothes, IPriceable
    {
        private NeckType _neckType;
        private SleeveType _sleeveType;
        public NeckType NeckType { get => _neckType; private set => _neckType = value; }
        public SleeveType SleeveType { get => _sleeveType; private set => _sleeveType = value; }

        public Shirt(NeckType neckType, SleeveType sleeveType, ClothesQuality quality, float unitPrice)
        {
            NeckType = neckType;
            SleeveType = sleeveType;
            Quality = quality;
            UnitPrice = unitPrice;
        }

        public override float Price(float pricing = 0f)
        {
            pricing = UnitPrice;

            if (SleeveType == SleeveType.shortSleeve)
                pricing *= 0.9f;
            if (NeckType == NeckType.maoNeck)
                pricing *= 1.03f;

            pricing = base.Price(pricing);

            return pricing;
        }
    }
}
