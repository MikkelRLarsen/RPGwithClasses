using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Characters.StatsbasedCharacters.Enemies
{
    internal class Boss : Enemy
    {
        public int? BossID { get; private set; }
        public double? DamageMultiplier { get; private set; }
        public double? HealthRegenerationMultiplier { get; private set; }
    }
}
