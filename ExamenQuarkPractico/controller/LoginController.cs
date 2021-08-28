using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkPractico.controller
{
    class LoginController
    {
        public PricingController Login(string sellerName, string sellerSurname, string sellerCode)
        {
            return new PricingController(sellerName, sellerSurname, sellerCode);
        }
    }
}
