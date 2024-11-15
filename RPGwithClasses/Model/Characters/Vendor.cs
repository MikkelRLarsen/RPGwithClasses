using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Characters
{
    internal class Vendor : Character
    {
        public int? VendorID { get; private set; }
        public int Discount { get; private set; }
        public double VenderCostMultiplier { get; private set; }
    }
}
