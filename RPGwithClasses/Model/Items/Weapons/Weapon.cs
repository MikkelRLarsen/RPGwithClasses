using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Items.Weapons
{
    internal class Weapon : Item
    {
        public int WeaponID { get; private set; }
        public WeaponType? Type { get; private set; }
        public string? ClassRequirements { get; private set; }
        public string? LevelRequirements { get; private set; }
        public int Damage { get; private set; }
        public int Accuracy { get; private set; }
    }
}
