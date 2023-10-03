using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class QuillBoar : Monster
    {
        public bool Sneaky { get; set; }
        public QuillBoar(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage, string description, int dropChance, bool sneaky, string art) : base(name, hitChance, block, maxLife, minDamage, maxDamage, description, dropChance, art)
        {
            Sneaky = sneaky;
        }

       

        public Item DropLoot()
        {
            return new Item("5 + Max Health Charm", ItemType.MediumCharm, 5, "MaxLife");
        }

    }
}
