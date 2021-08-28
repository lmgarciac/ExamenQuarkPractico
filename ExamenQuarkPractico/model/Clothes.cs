using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenQuarkPractico.model
{
    abstract class Clothes : ICotizable
    {
        protected ClothesQuality _quality;
        protected float _unitPrice;
        public static Dictionary<ClothesType,int> stock = new Dictionary<ClothesType, int> { { ClothesType.shirt, 57},
                                                                                        {ClothesType.pants, 88 }};

        //Queda pendiente resolver el tema del STOCK
        //Arreglar todas las dependencias que se crearon que violan el modelo MVC
        public virtual float Price(float pricing)
        {
            if (_quality == ClothesQuality.premiumQuality)
                pricing *= 1.3f;

            return pricing;
        }

        public int GetStock()
        {

            return 0;
        }
    }
}
