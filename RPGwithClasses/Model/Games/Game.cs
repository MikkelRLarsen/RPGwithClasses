using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGwithClasses.Model.Games.Stories;
using RPGwithClasses.Model.Games.Users;

namespace RPGwithClasses.Model.Games
{
    internal class Game
    {
        public int GameID { get; private set; }
        public DateTime LastLogin { get; private set; }
        public string? GameName { get; private set; }
        public DateTime CreationTime { get; private set; }
        public int CurrentStep { get; private set; }
        public GameStatus? GameStatus { get; private set; }
        public Story? Story { get; private set; }
        public User? User { get; private set; }
    }
}
