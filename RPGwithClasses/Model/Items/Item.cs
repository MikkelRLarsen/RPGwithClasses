using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Items
{
    internal abstract class Item
    {
        public int ItemID { get; protected set; }
        public int VenderCost { get; protected set; }
    }
}
