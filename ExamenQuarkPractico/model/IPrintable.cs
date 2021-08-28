using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenQuarkPractico.model
{
    interface IPrintable
    {
        void Print(); 
        //Not implemented, this would be implemented in every object that would need to be printed (princing history / single pricing / etc.)
    }
}
