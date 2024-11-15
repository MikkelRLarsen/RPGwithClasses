using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Inventories
{
    internal class Inventory
    {
        public int InvetoryID { get; protected set; }
        public int ItemCapacity { get; protected set; }
        public int CurrencyAmount { get; protected set; }
    }
}
