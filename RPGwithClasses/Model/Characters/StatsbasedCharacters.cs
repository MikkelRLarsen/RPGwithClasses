using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Character
{
    internal abstract class StatsbasedCharacters : Character
    {
        public int? StatsbasedCharactersID { get; protected set; }
        public int Level { get; protected set; }
        public int Agility { get; protected set; }
        public int Strength { get; protected set; }
        public int Intellect { get; protected set; }
        public int Block { get; protected set; }
        public int CurrentHealth { get; protected set; }
        public int MaxHealth { get; protected set; }
        public int CurrentResource { get; protected set; }
        public int MaxResource { get; protected set; }
        public Weapon? EquippedWeapon { get; protected set; }
    }
}
