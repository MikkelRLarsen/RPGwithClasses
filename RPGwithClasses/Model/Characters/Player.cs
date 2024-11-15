using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Character
{
    internal class Player : StatsbasedCharacters
    {
        public int? PlayerID { get; private set; }
    }
}
