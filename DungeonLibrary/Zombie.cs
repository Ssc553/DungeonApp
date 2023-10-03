using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Zombie : Monster
    {
        public Zombie(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage, string description, int dropChance, string art) : base(name, hitChance, block, maxLife, minDamage, maxDamage, description, dropChance, art)
        {
        }

        public bool ShouldDropLoot()
        {
            bool dropLoot = false;
            int numberToBeat = Random.Shared.Next(1, 101);
            if (DropChance >= numberToBeat)
            {

                dropLoot = true;
            }
            return dropLoot;

        }
       public Item DropLoot()
        {
            if (ShouldDropLoot())
            {
                return new Item("2 + Damage Charm", ItemType.SmDmgCharm, 2, "Damage");
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            return new Item("Nothing", ItemType.UselessJunk, 0, "Not even your mother would hold onto this!");
            Console.ResetColor();
            // return new Item("Large Health Charm", ItemType.LargeCharm, 10, "MaxLife");
        }
    }
}
