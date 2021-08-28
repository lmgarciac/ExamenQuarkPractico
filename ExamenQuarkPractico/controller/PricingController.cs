using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenQuarkPractico.model;
using ExamenQuarkPractico.Enums;

namespace ExamenQuarkPractico.controller
{
    public class PricingController
    {
        private Seller _currentSeller;
        public PricingController(string sellerName, string sellerSurname, string sellerCode)
        {
            GenerateInitialStock();
            CurrentSeller = new Seller(sellerName, sellerSurname, sellerCode);
            Shop.Seller = CurrentSeller;
        }

        public Seller CurrentSeller { get => _currentSeller; set => _currentSeller = value; }

        public float CalculatePrice(ClothesType clothesType, ClothesQuality clothesQuality, NeckType neckType, SleeveType sleeveType, PantsFitType pantsFitType, float unitPrice, int quantity)
        {
            float finalPrice = 0f;
            switch (clothesType)
            {
                case ClothesType.shirt:
                    Shirt shirt = new Shirt(neckType, sleeveType, clothesQuality, unitPrice);
                    finalPrice = shirt.Price() * quantity;
                    break;
                case ClothesType.pants:
                    Pants pants = new Pants(pantsFitType,clothesQuality,unitPrice);
                    finalPrice = pants.Price() * quantity;
                    break;
                default:
                    break;
            }

            RegisterPricing(CurrentSeller.Id, clothesType, quantity, finalPrice);

            return finalPrice;
        }

        private void RegisterPricing(string sellerId, ClothesType clothesType, int quantity, float finalPrice)
        {
            int pricingid = CurrentSeller.Pricings.Count + 1;
            Pricing _currentPricing = new Pricing(pricingid, DateTime.Now, CurrentSeller.Id, clothesType, quantity, finalPrice);
            CurrentSeller.Pricings.Add(_currentPricing);
        }

        public void GenerateInitialStock()
        {
            Shop.GenerateInitialStock();
        }

        public int GetStock(ClothesType clothesType, ClothesQuality clothesQuality = ClothesQuality.none, SleeveType sleeveType = SleeveType.none, NeckType neckType = NeckType.none)
        {
            return Shop.GetStock(clothesType, clothesQuality, sleeveType, neckType);
        }

        public int GetStock(ClothesType clothesType, ClothesQuality clothesQuality = ClothesQuality.none, PantsFitType pantsFitType = PantsFitType.none)
        {
            return Shop.GetStock(clothesType, clothesQuality, pantsFitType);
        }

        public string GetShopName()
        {
            return Shop.Name;
        }

        public string GetShopAddress()
        {
            return Shop.Address;
        }
    }
}
