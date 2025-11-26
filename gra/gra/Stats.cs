using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gra
{
    public class Stats
    {
        public int Hp { get; set; }
        public int Dmg { get; set; }
        public string Name { get; set; }
    }
    public class Archer : Stats
    {
        public Archer()
        {
            Hp = 10000;
            Dmg = 580;
            Name = "Archer";
        }
    }
    public class Warrior : Stats
    {
        public Warrior()
        {
            Hp = 15850;
            Dmg = 370;
            Name = "Warrior";
        }
    }
    public class Mage : Stats
    {
        public Mage()
        {
            Hp = 7370;
            Dmg = 1760;
            Name = "Mage";
        }
    }
}