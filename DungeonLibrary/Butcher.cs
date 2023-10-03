using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class Butcher : Monster
    {
        public Butcher(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage, string description, int dropChance, int lifeLeach, string art ) : base(name, hitChance, block, maxLife, minDamage, maxDamage, description, dropChance, art)
        {
            LifeLeach = lifeLeach;
        }

        public int LifeLeach { get; set; }
        

       

        public override int CalcDamage()
        {
            int result = 0;// Create return object

            Random rand = new Random();// Setup necessary recources

            result = rand.Next(MinDamage, MaxDamage + 1);
            Life = Life  + LifeLeach;// Modify the return object
            return result;
            

        }


        public Item DropLoot()
        {
            return new Item(" + 8 Damage Charm", ItemType.LargeCharm, 8, "Damage");
        }

    }
}
