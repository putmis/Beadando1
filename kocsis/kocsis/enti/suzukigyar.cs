using kocsis.absztrakt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kocsis.enti
{
    class suzukigyar: tutukFactory
    {
        public tutuk CreateNew()
        {
            return new suzuki();
        }
    }
}
