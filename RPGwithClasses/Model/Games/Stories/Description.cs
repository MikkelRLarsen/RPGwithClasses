using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Games.Stories
{
    internal class Description
    {
        public int DescriptionID { get; private set; }
        public string? Teaser { get; private set; }
        public string? BaggroundStory { get; set; }
    }
}
