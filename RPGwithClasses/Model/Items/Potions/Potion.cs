using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Items.Potions
{
    internal class Potion : Item
    {
        public int PotionID { get; private set; }
        public PotionType? Type { get; private set; }
        public int Potency { get; private set; }
        public int Uses { get; private set; }
    }
}
