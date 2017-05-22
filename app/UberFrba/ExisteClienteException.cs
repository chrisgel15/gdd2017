using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UberFrba
{
    public class ExisteClienteException : Exception
    {        
        public ExisteClienteException(string message) : base(message)
        {
            
        }

    }
}
