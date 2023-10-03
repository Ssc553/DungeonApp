using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{

    public class Player : Character
    {
        private WeaponType staff;
        private CharacterClass amazon;
        private int v1;
        private int v2;
        private int v3;

        public Weapon EquippedWeapon { get; set; }
        public int Score { get; set; }
        public List<Item> Inventory { get; set; }
        public int MinDmg { get; set; }

        public int MaxDmg { get; set; }
        //Constructors

        public Player(string name, int hitChance, int block, int maxLife, Weapon equippedWeapon, CharacterClass characterClass, int score, int minDmg, int maxDmg) : base(name, hitChance, block, maxLife)
        {
            HitChance = hitChance ;
            EquippedWeapon = equippedWeapon;
            #region Potential Expansion: Class(race) Bonuses

            #endregion
            switch (characterClass)
            {
                case CharacterClass.Barbarian:
                    MaxLife += 10;
                    Life = MaxLife;
                    if (EquippedWeapon.Type == WeaponType.Axe)
                    {
                        HitChance += 10;
                        minDmg += 3;
                        maxDmg += 5;
                    }
                    break;
                case CharacterClass.Sorcerer:
                    Block += 20;
                    if (EquippedWeapon.Type == WeaponType.Staff)
                    {
                        HitChance += 10;
                        minDmg += 3;
                        maxDmg += 5;
                    }
                    break;
                case CharacterClass.Rouge:
                    if (EquippedWeapon.Type == WeaponType.Dagger)
                    {
                        HitChance += 10;
                        minDmg += 3;
                        maxDmg += 5;
                    }
                    HitChance += 10;
                    break;
                case CharacterClass.Amazon:
                    MaxLife += 5;
                    Life = MaxLife;
                    Block += 10;
                    if (EquippedWeapon.Type == WeaponType.Bow)
                    {
                        HitChance += 20;
                        minDmg += 3;
                        maxDmg += 5;
                    }
                    break;

                default:
                    break;
            }
            Score = score;
            Inventory = new List<Item>();
            MinDmg = minDmg;
            MaxDmg = maxDmg;
        }

        public Player(string name, int hitChance, int block, int maxLife, WeaponType staff, CharacterClass amazon, int v1, int v2, int v3) : base(name, hitChance, block, maxLife)
        {
            this.staff = staff;
            this.amazon = amazon;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        //string description;

        //Methods

        public void RefreshAfterLooting()
        {
            Inventory.ForEach(item =>
            {
            if (!item.Equipped && item.Stat == "MaxLife")
                {
                    MaxLife += item.StatMod;
                    Life += item.StatMod;

                }
                else if (!item.Equipped && item.Stat == "Damage")
                {
                    MinDmg += item.StatMod;
                    MaxDmg += item.StatMod;
                }
                
                item.Equipped = true;

               
            }
            );
        }

        public bool ShouldCrit()
        {
            bool isCrit = false;


            int numberToBeat = Random.Shared.Next(1, 101);// Excludes Max value so returns "1-100"
            if (EquippedWeapon.CritChance > numberToBeat)
            {
                isCrit = true;
            }
            return isCrit;


        }
        

        public override int CalcDamage()
        {
            decimal result = 0;// Create return object
                               //                 int minDamage = EquippedWeapon.MinDamage;
                               //                 int maxDamage = EquippedWeapon.MaxDamage;
                               //Method to change   if (EquippedWeapon.Type == WeaponType.Katana && PlayerClass == CharacterClass.Assassin)
                               // class weapon    {
                               //    damahge      minDamage = += 3;
                               //                     maxDamage = += 5;
                               //                 }


            Random rand = new Random();// Setup necessary recources

             result = rand.Next(EquippedWeapon.MinDamage + MinDmg, EquippedWeapon.MaxDamage + MaxDmg + 1);// Modify the return object
            if (ShouldCrit())// == true
            {
                result = result * 1.5m ;// Critical Strikes add three damage
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"You deal a Critical hit of {result} damage");
                Console.ResetColor();
            }
            return (int)result;

            //return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);// single line version
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }
        public override string ToString()
        {
            return base.ToString()+ 
             $"Damage: {EquippedWeapon.MinDamage + MinDmg} - {EquippedWeapon.MaxDamage + MaxDmg}\n" +
             $"Score: {Score}"; 
        }

       // public override int CalcSpecial()
       // {
       //     throw new NotImplementedException();
       // }
    }
}
