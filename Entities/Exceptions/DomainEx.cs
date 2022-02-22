using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_reserva.Entities.Exceptions
{
    class DomainEx : ApplicationException
    {
        public DomainEx(string message) : base(message)
        {

        }
    }
}
