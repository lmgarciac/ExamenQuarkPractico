using System;
using System.Collections.Generic;
using System.Text;
using ExamenQuarkPractico.Enums;

namespace ExamenQuarkPractico.model
{
    public static class Shop
    {
        private static string _name = "Quark Academy Clothes Shop";
        private static string _address = "742 Evergreen Terrace";
        private static List<ClothesType> _clothesForSale = new List<ClothesType> { ClothesType.pants, ClothesType.shirt };
        private static Seller _seller;
        private static List<Pants> _pantsStock = new List<Pants>();
        private static List<Shirt> _shirtsStock = new List<Shirt>();

        public static string Name { get => _name;}
        public static string Address { get => _address;}
        public static List<ClothesType> ClothesForSale { get => _clothesForSale;}
        public static Seller Seller { get => _seller; set => _seller = value; }

        public static List<Pants> PantsStock { get => _pantsStock; set => _pantsStock = value; }
        public static List<Shirt> ShirtsStock { get => _shirtsStock; set => _shirtsStock = value; }

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

    }
}
