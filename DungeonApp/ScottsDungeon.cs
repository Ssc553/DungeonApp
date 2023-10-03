using System.Net;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using DungeonLibrary;
namespace DungeonApp
{
    internal class ScottsDungeon
    {
       
        static void Main(string[] args)
        {
            

            
            Weapon wep = null;
            
            Console.Clear();
            bool wepSelect = false;
            bool quit = false;
            
            do
            {
                Console.Write("\nPlease choose a Weapon:\n" +
                              "\nA) Axe: Adds 5-9 Dmg, HitChance : +10%, Crit: 45%\n" +
                              "\nD) Dagger: Adds 6-8 Dmg, HitChance +10%, Crit: 50%\n" +
                              "\nS) Staff: Adds 8-10 Dmg, HitChance +10%, Crit: 35% \n" +
                              "\nB) Bow: Adds 4-10 Dmg, HitChance +20%, Crit: 60%\n" +
                              "\nE) Exit\n");
                string weapon = Console.ReadKey(true).Key.ToString();
                Console.Clear();
                switch (weapon)
                {
                    case "A":
                        wep = new("Axe", 5, 9, 10, false, WeaponType.Axe, 45);

                        wepSelect = true;


                        break;
                    case "D":
                        wep = new("Dagger", 6, 8, 10, false, WeaponType.Dagger, 50);
                        wepSelect = true;


                        break;
                    case "S":
                        wep = new("Staff", 8, 10, 10, true, WeaponType.Staff, 35);

                        wepSelect = true;

                        break;
                    case "B":
                        wep = new("Bow", 4, 10, 20, true, WeaponType.Bow, 60);
                        wepSelect = true;
                        break;
                    case "X":
                        quit = true;
                        Console.WriteLine("Thanks for playing");
                        Environment.Exit(2);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            } while (!wepSelect && !quit);

            Player player = null;
            bool quit2 = false;
            bool charSelect = false;
            do
            {
                Console.Write("\nPlease choose Character:\n" +
                                  "\nB) Barbarian: Well versed in combat with Axes\n" +
                                  "\nS) Sorcerer: Best Paired with a Staff\n" +
                                  "\nR) Rouge: Prefers to wield a Dagger\n" +
                                  "\nA) Amazon: Ranged class with a mastery in archery\n" +
                                  "\nE) Exit\n");
                string character = Console.ReadKey(true).Key.ToString();
                Console.Clear();
                switch (character)
                {
                    case "B":
                        charSelect = true;
                        
                        player = new Player ("Barb", 61, 35, 80, wep, CharacterClass.Barbarian,0,1,2);

                        break;
                    case "S":
                        charSelect = true;
                        player = new Player("Sorc", 71, 25, 75, wep, CharacterClass.Sorcerer,0,1,2);

                        break;
                    case "R":
                        charSelect = true;
                        player = new Player("Rogue", 71, 35, 70, wep, CharacterClass.Rouge,0,1,2);
                        break;
                    case "A":
                        charSelect = true;
                        player = new Player("Amazon", 51, 30, 75, wep, CharacterClass.Amazon,0, 1,2);
                        break;
                    case "X":
                        quit2 = true;
                        Console.WriteLine("Thanks for playing");
                        Environment.Exit(0);
                        break; 

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                
                
            } while (!charSelect && !quit2);
            
            #region Player Creation
            // _possible expansion - Display a list of precreated weapons and let them pick one.
            //- recommendation: GetWeapon() in the Weapon class that returns a Weapon
            #endregion
            
            bool exit = false;
            do
            {

                string room = GetRoom();
                Console.WriteLine(room);

                Monster monster = Monster.GetMonster();
                Console.Write("\n In this room: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(monster.Name);
                Console.WriteLine(monster.Art);
                Console.ResetColor();

                bool reload = false;//reload = true to "reload" a room and a monster
                do
                {

                    #region Menu
                    //prompt the user:
                    Console.Write("\nPlease choose an action:\n" +
                                  "A) Attack\n" +
                                  "R) Run away\n" +
                                  "P) Player Info\n" +
                                  "M) Monster Info\n" +
                                  "I) Player Inventory\n" +
                                  "H) Use a Health Potion for \"3\" Score Points" +
                                  "E) Exit\n");
                    //Capture user's menu selection
                    string menuSelection = Console.ReadKey(true).Key.ToString();//Executes upon input without hitting enter
                    //Clear the console AFTER user input
                    Console.Clear();

                    //using branching logic to act upon the user's menu selection
                    switch (menuSelection)
                    {
                        case "A":
                            Console.WriteLine("Combat!");
                            Console.WriteLine(monster.Art);
                            //if the monster is dead, DoBattle returns true and reloads the room
                            reload = Combat.DoBattle(player, monster);
                            break;

                        case "R":
                            Console.WriteLine("Run Away!");
                            //TODO put free monster attack here
                            //get a new monster and a new room:
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            reload = true;
                            break;

                        case "P":
                            Console.WriteLine("Player Info");
                            Console.WriteLine(player);
                            Thread.Sleep(2000);
                            Console.Write("\n In this room: ");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine(monster.Name);
                            Console.ResetColor();

                            //TODO print player info here
                            break;

                        case "M":
                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);
                            //TODO print monster info here
                            break;

                        case "E":
                            Console.WriteLine("No one likes a quitter...");
                            //exit both loops
                            exit = true;
                            break;

                        case "H":
                            if (player.Score >= 3)
                            { 
                                player.Life = player.Life + 20;
                                player.Score = player.Score - 3;
                                Console.WriteLine("You heal for 20 Hit Points!");
                                Console.WriteLine(player);
                            }
                            else
                            {
                                Console.WriteLine(player);
                                Console.WriteLine("You don't have enough points to heal");
                                
                            }
                            break;

                        default:
                            //invalid input.
                            Console.WriteLine("You've Chosen Poorly");
                            break;
                    }// end switch
                    #endregion

                    

                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Dude... You died!\a");
                        exit = true; // Leave both loops.
                    }
                } while (!reload && !exit);// && !barb
                //if exit = true, both loops will terminate.
                //If reload = true, only the inner loop will terminate.
            } while (!exit); //exit == false
            Console.WriteLine($"You finished with a score of {player.Score}!");//{(player.Score == 1 ? . : s.
            
        }//end Main()
        
        private static string GetRoom()
        {
            //Collection Initilazation Syntax
            string[] rooms = {
                "Dark room with corpses littering the floor.", //TODO Ask about adding the BUTCHER to this room
                "Whimsical forest with a path to a small cave",
                "Musty Cellar ",
                "Cave with lava flowing to the center of the room",
                "You've found yourself high up in a tree."};


            Random randOut = new Random();
            int randIndex = randOut.Next(rooms.Length);
            string room = rooms[randIndex];
            return room;

           
        }
    }//end class
}//end namespace

