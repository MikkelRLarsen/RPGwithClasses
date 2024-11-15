using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Games.Users
{
    internal class Login
    {
        public User UserID { get; private set; }
        private string UserName { get; set; }
        private string Password { get; set; }
    }
}
