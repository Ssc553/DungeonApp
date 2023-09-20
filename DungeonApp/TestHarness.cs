using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
namespace DungeonApp
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {

            Weapon w1 = new Weapon();
            w1.Name = "Short Sword";
            w1.MaxDamage = 6;
            w1.MinDamage = 1;
            w1.BonusHitChance = 5;
            w1.IsTwoHanded = false;
            Console.WriteLine($"\t {w1.Name}\n" +
                         $"Min Dmg {w1.MinDamage} \n" +
                         $"Max Dmg {w1.MaxDamage}\n" +
                $"Bonus Hit Chance {w1.BonusHitChance}\n" +
                $"{(w1.IsTwoHanded ? "One Handed" : "Two Handed")} Weapon");
            Console.WriteLine($@"
                            {w1.Name}

                         Min Dmg {w1.MinDamage}
                         Max Dmg {w1.MaxDamage}
                Bonus Hit Chance {w1.BonusHitChance}

                           {(w1.IsTwoHanded ? "One Handed" : "Two Handed")}");

            Character c1 = new Character("Name", 40, 5, 50) { Life = 20 }; // EXAMPLE
            Console.WriteLine(c1);
        }
    }
}
//$"This is a "{ (w1.IsTwoHanded ? "One Handed " : "Two Handed")} "Weapon"; 
