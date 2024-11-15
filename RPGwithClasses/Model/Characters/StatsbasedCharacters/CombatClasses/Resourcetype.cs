using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Characters.StatsbasedCharacters.CombatClasses
{
    internal class Resourcetype
    {
        public int ResourcetypeID { get; private set; }
        public string? Type { get; private set; }
        public int EndOfTurnRegeneration { get; set; }
    }
}
