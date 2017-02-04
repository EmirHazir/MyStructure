using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emir.Entities.Concrete
{
    public class CartLine
    {
        public Urun Urun { get; set; }
        public int Adet { get; set; }
    }
}
