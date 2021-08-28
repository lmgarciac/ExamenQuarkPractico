using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenQuarkPractico.model;

namespace ExamenQuarkPractico.controller
{
    class PriceController
    {
        public float CalculatePrice(ClothesType clothesType, ClothesQuality clothesQuality, NeckType neckType, SleeveType sleeveType, PantsFitType pantsFitType, float unitPrice)
        {
            switch (clothesType)
            {
                case ClothesType.shirt:
                    Shirt shirt = new Shirt(neckType, sleeveType, clothesQuality, unitPrice);
                    return shirt.Price();
                case ClothesType.pants:
                    Pants pants = new Pants(pantsFitType,clothesQuality,unitPrice);
                    return pants.Price();
                default:
                    break;
            }
            return 0f;
        }
    }
}
