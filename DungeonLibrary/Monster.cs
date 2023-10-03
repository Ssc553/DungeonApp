using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //What you put in here is entirely up to you. You should attempt to create at least one of each custom datatype and test the functionality as we progress.
        //Nothing in here has any impact on the rest of the program. It's your playground for our new datatypes.
        //Character c1 = new Character("Name", 40, 5, 50);

        //Character c2 = new Character()
        //{
        //    Name = "New Name",
        //    HitChance = 0,
        //    Block = 2,
        //    MaxLife = 50,
        //    Life = 50
        //};
        //Monster m1 = new Monster("", 0, 0, 0, 0, 0, "");
        // Character c1 = m1;//polymorphism. BOXING - storing a monster as a character
        //Console.WriteLine(c1);
        //Weapon w1 = new Weapon("Stick", 1, 5, 1, false, WeaponType.Staff());
        //Console.WriteLine(w1);

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int DropChance { get; set; }
        public string Art { get; set; }

        //(string name, int hitChance, int block, int maxLife)
        public Monster(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage, string description, int dropChance, string art) : base(name, hitChance, block, maxLife)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Description = description;
            DropChance = dropChance;
            Art = art;
        }


        public Monster()
        {

        }

       //public Monster(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage, string description) : base(name, hitChance, block, maxLife)
       //{
       //}// Special monster CTOR

        public override int CalcDamage()
        {
            int result = 0;// Create return object

            Random rand = new Random();// Setup necessary recources

            result = rand.Next(MinDamage, MaxDamage + 1);// Modify the return object
            return result;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nDamage {MinDamage} - " +
                     $"{MaxDamage}\n" +
                     $"{Description}";

        }
        // return base.ToString();
        //     return $"----- {Name} -----\n" +
        //         $"Life: {Life} of {MaxLife}\n" +
        //         $"Hit Chance: {HitChance}%\n" +
        //         $"Block: {Block}%";
        public static Monster GetMonster()
        {
            Skeleton m1 = new("Skeleton", 50, 20, 30, 2, 8, "Bleached bones of fallen heros rise from the ground.",50, @"
                              .'  Y '>,
  \ \                        / _   _   \
   \\\                       )(_) (_)(|}
    \\\                      {  4A   } /
     \\\                      \uLuJJ/\l
      \\\                     |3    p)/
       \\\___ __________      /nnm_n//
       c7___-__,__-)\,__)("".  \_>-<_/D
                  //V     \_""-._.__G G_c__.-__<""/ ( \
                         <""-._>__-,G_.___)\   \7\
                        (""-.__.| \""<.__.-"" )   \ \
                              ");

            Zombie m2 = new("Zombie", 60, 20, 40, 4, 8, "Undead Zombie with decaying flesh falling from its bones",50, @"     
          _,-""""-._
        ,""        "".
       /    ,-,  ,""\
      ""    /   \ | o|
      \    `-o-""  `-',
       `,   _.--'`'--`
         `--`---'                   
           ,' '      
         ./ ,  `,    
         / /     \
        (_)))_ _,""
           _))))_,
          (_,-._)))");
            QuillBoar m3 = new("Quillboar", 80, 20, 35, 2, 4, "Fierce Boar with thousands of razor sharp Quills", 100,true, @" 
                _,-""""""""-..__
         |`,-'_. `  ^ ^^  `--'"""""".
         ;  ,'  | `` ^^^ `  ` ```  `.
       ,-'   ..-' ` ` `` `  ``^^  ` |==.
     ,'    ^    `  `    `` `  ` `.  ;   \
    `}_,-^-   _ .  ` \ `  ` __ `   ;    #
       `""---""' `-`. ` \---""""`.`.  `;
                  \\` ;       ; `. `,
                   ||`;      / / | |
                  //_;`    ,_;' ,_;""");
            Diablo m4 = new("Diablo", 90, 40, 250, 25, 70, "The Lord of Terror!", 100,15, @"                        
                            ,-.
       ___,---.__          /'|`\          __,---,___
    ,-'    \`    `-.____,-'  |  `-.____,-'    //    `-.
  ,'        |           ~'\     /`~           |        `.
 /      ___//              `. ,'          ,  , \___      \
|    ,-'   `-.__   _         |        ,    __,-'   `-.    |
|   /          /\_  `   .    |    ,      _/\          \   |
\  |           \ \`-.___ \   |   / ___,-'/ /           |  /
 \  \           | `._   `\\  |  //'   _,' |           /  /
  `-.\         /'  _ `---'' , . ``---' _  `\         /,-'
     ``       /     \    ,='/ \`=.    /     \       ''
             |__   /|\_,--.,-.--,--._/|\   __|
             /  `./  \\`\ |  |  | /,//' \,'  \
           /   /     ||--+--|--+-/-|     \   \
           |   |     /'\_\_\ | /_/_/`\     |   |
            \   \__, \_     `~'     _/ .__/   /
             `-._,-'   `-._______,-'   `-._,-'");
            SkeletonKing m5 = new("Skeleton King", 70, 20, 55, 12, 28, "Monster 5", 75, 5, @"  
   ,    ,    /\   /\
  /( /\ )\  _\ \_/ /_
  |\_||_/| < \_   _/ >
  \______/  \|0   0|/
    _\/_   _(_  ^  _)_
   ( () ) /`\|V""""""V|/`\
     {}   \  \_____/  /
     ()   /\   )=(   /\
     {}  /  \_/\=/\_/  \");
            Butcher m6 = new("The Butcher", 70, 40, 45, 10, 25, "Ahhh Fresh Meat!", 75,5, "");
            Monster m = new();
            List<Monster> monsters = new()
            {m1,m1,m1,m1,m1,m1,m1,m1,m1,m1,m1,m1,m1,m1,m1,m1,   //5/17
            m2,m2,m2,m2,m2,m2,m2,m2,m2,m2,m2,m2,m2,m2,    //4/17
            m3,m3,m3,m3,m3,m3,m3,m3,m3,          //3/17
            //m4,m4,
            m5,m5,m5,m5,
            m6,m6,m6,m6,
            m4

            };// m1,m1,m1,m1,m1,m1,m1,m1,m1,m1,m1,m1,m1

            Random rand = new Random();
            int randomIndex = rand.Next(monsters.Count);
            m = monsters[randomIndex];
            return m;

            //refacter
            return monsters[new Random().Next(monsters.Count)];

        }
        
        

       // public override int CalcSpecial()
       // {
       //     throw new NotImplementedException();
       // }
    }
}
