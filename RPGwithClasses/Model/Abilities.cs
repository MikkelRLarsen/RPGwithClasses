using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model
{
    internal class Abilities
    {
        public int AbilitiesID { get; private set; }
        public int Cost { get; private set; }
        public AbilitiesType? Type { get; private set; }
        public int LevelRequirements { get; set; }
        public int ClassRequirements { get; set; }
    }
}
