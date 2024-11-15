using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGwithClasses.Model.Games.Stories
{
    internal class Story
    {
        public int StoryID { get; private set; }
        public int Difficulity { get; private set; }
        public int AmountOfSteps { get; private set; }
        public Description Description { get; private set; }
    }
}
