using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model
{
    internal class CombatClass
    {
        public int CombatClassID { get; private set; }
        public string? Type { get; private set; }
        public Resourcetype? ResourceType { get; private set; }
        public int HealthRegeneration { get; private set; }
    }
}
