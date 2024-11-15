using RPGwithClasses.Model.Games;
using RPGwithClasses.Model.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Characters
{
    internal abstract class Character
    {
        public int? CharacterID { get; protected set; }
        public string? Name { get; protected set; }
        public Game Game { get; protected set; }
        public Inventory Inventoryeee { get; set; }
    }
}
