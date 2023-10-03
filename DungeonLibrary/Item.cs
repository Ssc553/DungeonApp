using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Item
    {


        public string ItemName { get; set; }
        public ItemType Type { get; set; }
        public int StatMod { get; set; }
        public string Stat { get; set; }
        public bool Equipped { get; set; }

        public Item(string itemName, ItemType itemType, int statMod, string stat)
        {
            ItemName = itemName;
            StatMod = statMod;
            Type = itemType;
            Stat = stat;
            Equipped = false;
        }


    }
    public enum ItemType 
    {
        SmDmgCharm,
        MedDmgCharm,
        LgDmgCharm,
        SmallCharm,
        MediumCharm,
        LargeCharm,
        UselessJunk
    }
}

