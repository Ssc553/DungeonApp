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

           //                              Weapon w1 = new Weapon();
           //                              w1.Name = "Short Sword";
           //                              w1.MaxDamage = 6;
           //                              w1.MinDamage = 1;
           //                              w1.BonusHitChance = 5;
           //                              w1.IsTwoHanded = false;
           //                              Console.WriteLine($"\t {w1.Name}\n" +
           //                                           $"Min Dmg {w1.MinDamage} \n" +
           //                                           $"Max Dmg {w1.MaxDamage}\n" +
           //                                  $"Bonus Hit Chance {w1.BonusHitChance}\n" +
           //                                  $"{(w1.IsTwoHanded ? "One Handed" : "Two Handed")} Weapon");
           //                              Console.WriteLine($@"
           //                                              {w1.Name}
           //                             
           //                                           Min Dmg {w1.MinDamage}
           //                                           Max Dmg {w1.MaxDamage}
           //                                  Bonus Hit Chance {w1.BonusHitChance}
           //                             
           //                                             {(w1.IsTwoHanded ? "One Handed" : "Two Handed")}");
            /////////////////////////////////CharClasses///////////////////////////////////

           // Character barb = new Character("Barbarian", 40, 15, 60);// (string name, int hitChance, int block, int maxLife)
           // Console.WriteLine(barb);
           // Console.WriteLine();
           // Character sorc = new Character("Sorcerer", 60, 5, 40); //{ Life = 20 }; // EXAMPLE
           // Console.WriteLine(sorc);
           // Console.WriteLine();
           // Character rouge = new Character("Rouge", 40, 10, 50);  // (string name, int hitChance, int block, int maxLife)
           // Console.WriteLine(rouge);
           // Console.WriteLine();
           // Character ama = new Character("Amazon", 60, 0, 45);   // (string name, int hitChance, int block, int maxLife)
           // Console.WriteLine(ama);
           // Console.WriteLine();
           // Character asn = new Character("Assassin", 55, 15, 45);   // (string name, int hitChance, int block, int maxLife)
           // Console.WriteLine(asn);
           // Console.WriteLine();
           //
            //  /////////////////////////////WEAPONS///////////////////////////


         //   Weapon sword = new Weapon("Short Sword", 1, 4, 15,false, WeaponType.Sword);
         //   Console.WriteLine(sword);
         //   Console.WriteLine();
         //   Weapon greatSword = new Weapon("The Grand Father", 12, 16, 25, true, WeaponType.Colossus_Blade);
         //   Console.WriteLine(greatSword.ToString().Replace("_"," "));
         //   Console.WriteLine();
         //
         //   Weapon axe = new Weapon("Small Axe", 2, 5, 8, false, WeaponType.Axe);
         //   Console.WriteLine(axe);
         //   Console.WriteLine();
         //   Weapon greatAxe = new Weapon("Hell Slayer", 6, 15, 18, true, WeaponType.Great_Axe);
         //   Console.WriteLine(greatAxe.ToString().Replace("_"," "));
         //   Console.WriteLine();
         //   Weapon staff = new Weapon("Staff", 2, 6, 35, true, WeaponType.Staff);
         //   Console.WriteLine(staff);
         //   Console.WriteLine();
         //   Weapon dagger = new Weapon("Dagger", 1, 3, 40, false, WeaponType.Dagger);
         //   Console.WriteLine(dagger);
         //   Console.WriteLine();
         //   Weapon shortBow = new Weapon("Short Bow", 1, 4,20 ,true, WeaponType.Short_Bow);
         //   Console.WriteLine(shortBow.ToString().Replace("_"," "));
         //   Console.WriteLine();
         //   Weapon longBow = new Weapon("Wind Force", 6, 12, 35, true, WeaponType.Long_Bow);
         //   Console.WriteLine(longBow.ToString().Replace("_"," "));
         //   Console.WriteLine();
         //   Weapon katana = new Weapon("Katana", 3, 6, 10, true, WeaponType.Katana);
         //   Console.WriteLine(katana);

            ///////////////////////////////WEAPONS/////////////////////////////



            //Monster monster = Monster.GetMonster();
            //Console.WriteLine( monster);

          //  Player player = new Player("player name", 70, 15, 75, "Sorc", longBow);
           // Console.WriteLine(player);
           // Console.WriteLine();

        }
    }
}
//$"This is a "{ (w1.IsTwoHanded ? "One Handed " : "Two Handed")} "Weapon"; 
