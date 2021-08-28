using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ExamenQuarkPractico.model
{
    public abstract class Clothes : ICotizable
    {
        protected ClothesQuality _quality;
        private float unitPrice;
        private static List<Pants> pantsStock = new List<Pants>();
        private static List<Shirt> shirtsStock = new List<Shirt>();

        protected ClothesQuality Quality { get => _quality; set => _quality = value; }
        public static List<Pants> PantsStock { get => pantsStock; set => pantsStock = value; }
        public static List<Shirt> ShirtsStock { get => shirtsStock; set => shirtsStock = value; }
        protected float UnitPrice { get => unitPrice; set => unitPrice = value; }


        public virtual float Price(float pricing)
        {
            if (Quality == ClothesQuality.premiumQuality)
                pricing *= 1.3f;

            return pricing;
        }

        public static void GenerateInitialStock()
        {
            AddToStock(ClothesType.shirt, ClothesQuality.standardQuality, SleeveType.shortSleeve, NeckType.maoNeck, amount: 100);
            AddToStock(ClothesType.shirt, ClothesQuality.premiumQuality, SleeveType.shortSleeve, NeckType.maoNeck, amount: 100);
            AddToStock(ClothesType.shirt, ClothesQuality.standardQuality, SleeveType.shortSleeve, NeckType.regularNeck, amount: 150);
            AddToStock(ClothesType.shirt, ClothesQuality.premiumQuality, SleeveType.shortSleeve, NeckType.regularNeck, amount: 150);
            AddToStock(ClothesType.shirt, ClothesQuality.standardQuality, SleeveType.longSleeve, NeckType.maoNeck, amount: 75);
            AddToStock(ClothesType.shirt, ClothesQuality.premiumQuality, SleeveType.longSleeve, NeckType.maoNeck, amount: 75);
            AddToStock(ClothesType.shirt, ClothesQuality.standardQuality, SleeveType.longSleeve, NeckType.regularNeck, amount: 175);
            AddToStock(ClothesType.shirt, ClothesQuality.premiumQuality, SleeveType.longSleeve, NeckType.regularNeck, amount: 175);

            AddToStock(ClothesType.pants, ClothesQuality.standardQuality, PantsFitType.skinnyFit, amount: 750);
            AddToStock(ClothesType.pants, ClothesQuality.premiumQuality, PantsFitType.skinnyFit, amount: 750);
            AddToStock(ClothesType.pants, ClothesQuality.standardQuality, PantsFitType.regularFit, amount: 250);
            AddToStock(ClothesType.pants, ClothesQuality.premiumQuality, PantsFitType.regularFit, amount: 250);
        }

        public static void AddToStock(ClothesType clothesType, ClothesQuality clothesQuality, SleeveType sleeveType, NeckType neckType, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Shirt shirt = new Shirt(neckType, sleeveType, clothesQuality, 0);
                ShirtsStock.Add(shirt);
            }
        }

        public static void AddToStock(ClothesType clothesType, ClothesQuality clothesQuality, PantsFitType pantsFitType, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Pants pants = new Pants(pantsFitType, clothesQuality, 0);
                PantsStock.Add(pants);
            }
        }

        public static int GetStock(ClothesType clothesType, ClothesQuality clothesQuality = ClothesQuality.none, SleeveType sleeveType = SleeveType.none, NeckType neckType = NeckType.none)
        {
            if (clothesType != ClothesType.shirt)
                return 0;

            int stock = 0;

            foreach (var shirt in ShirtsStock)
            {
                if ((shirt.Quality == clothesQuality || clothesQuality == ClothesQuality.none) &&
                    (shirt.SleeveType == sleeveType || sleeveType == SleeveType.none) &&
                    (shirt.NeckType == neckType || neckType == NeckType.none))
                {
                    stock++;
                }
            }

            return stock;
        }

        public static int GetStock(ClothesType clothesType, ClothesQuality clothesQuality = ClothesQuality.none, PantsFitType pantsFitType = PantsFitType.none)
        {
            if (clothesType != ClothesType.pants)
                return 0;

            int stock = 0;

            foreach (var pants in PantsStock)
            {
                if ((pants.Quality == clothesQuality || clothesQuality == ClothesQuality.none) &&
                    (pants.Type == pantsFitType || pantsFitType == PantsFitType.none))
                {
                    stock++;
                }
            }

            return stock;
        }
    }
}
