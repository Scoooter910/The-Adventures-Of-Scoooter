using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Adventures_of_Scoooter;

namespace The_Adventures_of_Scoooter
{
    internal class Knight : Character
    {
        public string Dog {get; set; }
        public string Cat { get; set; } 

        public string DogSpecialAbility { get; set; } = "Bite";

        public string CatSpecialAbility { get; set; } = "Claw";

        public string DogName { get; set; } = "Sir Henry";
        public string CatName { get; set; } = "Sir Carl";
    }
}
