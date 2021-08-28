using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkPractico.model
{
    interface IStockeable
    {
        int GetStock(ClothesQuality clothesQuality, 
                     SleeveType sleeveType = SleeveType.none, NeckType neckType = NeckType.none, 
                     PantsFitType pantsFitType = PantsFitType.none);
    }
}
