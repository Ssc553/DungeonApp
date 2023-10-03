using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class Diablo : Monster
    {
        public Diablo(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage, string description, int dropChance, int immolation, string art) : base(name, hitChance, block, maxLife, minDamage, maxDamage, description, dropChance, art)
        {
            Immolation = immolation;
        }

        public int Immolation { get; set; }

        public int CalcSpecial()
        {

            return Immolation;
        }

        public Item DropLoot()
        {
            return new Item(" 20 + Damage Charm", ItemType.LargeCharm, 20, "Damage");
        }


    }
}
