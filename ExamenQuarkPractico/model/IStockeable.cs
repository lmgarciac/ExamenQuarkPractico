using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenQuarkPractico.Enums;

namespace ExamenQuarkPractico.model
{
    interface IStockeable
    {
        int GetStock(ClothesQuality clothesQuality, 
                     SleeveType sleeveType = SleeveType.none, NeckType neckType = NeckType.none, 
                     PantsFitType pantsFitType = PantsFitType.none);
    }
}
