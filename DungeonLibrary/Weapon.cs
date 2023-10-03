using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    
    //WeaponType Type {get{}set{}}
    //CTOR
    //add WeaponType type to param list

    public class Weapon
    {
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private WeaponType _type;
        private int _critChance;
        public int MinDamage
            
        {
            get { return _minDamage; }
            set
            {
                //buisness rule:
                //0 < MinDamage >= MaxDamage
                if (value > 0 && value <= MaxDamage)
                {
                    //good to go
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            set
            {
                _maxDamage = value;
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int CritChance { get => _critChance; set => _critChance = value; }

        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded, WeaponType type, int critChance = 10)//MAYBE
        {
            //ANY properties that have business rules that depend on OTHER properties
            //must be assigned AFTER the independent properties are set.
            //MinDamage depends on MaxDamage, so MaxDamage MUST be set first.
            if (minDamage > maxDamage)
            {
                Console.WriteLine("Min Damage must not be more then Max Damage");
            }
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
            CritChance = critChance;
        }//Fully-Qualified Constructor


        public Weapon()
        {

        }

        //Method:
        public override string ToString()
        {
            //return base.ToString();//namespace.classname
            return $"--={Name}=--\n" +
                $"Damage: {MinDamage} - {MaxDamage}\n" +
                $"Bonus Hit: {BonusHitChance}%\n" +
                $"{(IsTwoHanded ? "Two-" : "One-")}Handed " +
                $"{Type}";// update with type

        }



        // //What's a property doing? 
        // public void SetName(string value)
        // {
        //     _name = value;
        // }
        // public string GetName()
        // {
        //     return _name;
        // }

    }//end class

}//end namespace


