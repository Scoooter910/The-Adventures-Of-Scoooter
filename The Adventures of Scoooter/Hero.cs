using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace The_Adventures_of_Scoooter
{
    public class Hero : Character
    {
        public string Weapon1 { get; set; } = "default";
        public string Weapon2 { get; set; } = "default";
        public string ArrowType1 { get; set; } = "default";
        public string ArrowType2 { get; set; } = "default";
    }
}
