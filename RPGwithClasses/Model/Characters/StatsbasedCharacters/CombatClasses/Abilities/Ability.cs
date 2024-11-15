using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Characters.StatsbasedCharacters.CombatClasses.Abilities
{
    internal class Ability
    {
        public int AbilityID { get; private set; }
        public int Cost { get; private set; }
        public AbilityType? Type { get; private set; }
        public int LevelRequirements { get; set; }
        public int ClassRequirements { get; set; }
    }
}
