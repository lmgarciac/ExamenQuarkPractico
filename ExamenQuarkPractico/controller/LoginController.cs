using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenQuarkPractico.model;

namespace ExamenQuarkPractico.controller
{
    class LoginController
    {
        public Seller Login(string sellerName, string sellerSurname, string sellerCode)
        {
            return new Seller(sellerName, sellerSurname, sellerCode);
        }
    }
}
