using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenQuarkPractico.model
{
    public static class Shop
    {
        private static string name = "Quark Academy Clothes Shop";
        private static string address = "742 Evergreen Terrace";
        private static List<ClothesType> clothesForSale = new List<ClothesType> { ClothesType.pants, ClothesType.shirt };

        public static string Name { get => name;}
        public static string Address { get => address;}
        public static List<ClothesType> ClothesForSale { get => clothesForSale;}
    }
}
