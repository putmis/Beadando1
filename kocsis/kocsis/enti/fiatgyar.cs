using kocsis.absztrakt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kocsis.enti
{
  public  class fiatgyar: tutukFactory
    {
        public tutuk CreateNew()
        {
            return new fiat();
        }
    }
}
