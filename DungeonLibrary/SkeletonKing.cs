using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class SkeletonKing : Monster
    {
        public int Thorns { get; set; }

        public SkeletonKing(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage, string description, int dropChance, int thorns, string art) : base(name, hitChance, block, maxLife, minDamage, maxDamage, description, dropChance, art)
        {
            Thorns = thorns;
        }


        // public SkeletonKing(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage, string description, int thorns) : base(name, hitChance, block, maxLife, minDamage, maxDamage, description)
        // {
        //     Thorns = thorns;
        // }
        public int CalcSpecial()
        {

            return Thorns;
        }
        public override int CalcBlock()
        {
            
            return base.CalcBlock();

        }

        public Item DropLoot()
        {
            return new Item(" 10 + Max Health Charm", ItemType.LargeCharm, 10, "MaxLife");
        }
       // public Item DropLoot()
       // {
       //     return new Item("Large Damage Charm", ItemType.LgDmgCharm, 10, "MaxLife");
       // }

        public SkeletonKing()
        {
                
        }

        
    }
}
