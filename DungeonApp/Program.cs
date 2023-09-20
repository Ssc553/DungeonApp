using System.Reflection.Metadata;
using System.Threading.Channels;

namespace DungeonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title/Introduction
            Console.WriteLine("Hello, World!");
            #endregion

            //TODO Create a player

            //Game loop:
            bool exit = false;
            do
            {
                //TODO generate a room
                string room = GetRoom();
                Console.WriteLine(room);

                //TODO generate a monster in the room

                //TODO Encounter loop:
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
                                  "X) Exit\n");
                    //Capture user's menu selection
                    string menuSelection = Console.ReadKey(true).Key.ToString();//Executes upon input without hitting enter
                    //Clear the console AFTER user input
                    Console.Clear();

                    //using branching logic to act upon the user's menu selection
                    switch (menuSelection)
                    {
                        case "A":
                            Console.WriteLine("Combat!");
                            //TODO put combat functionality here
                            break;

                        case "R":
                            Console.WriteLine("Run Away!");
                            //TODO put free monster attack here
                            //get a new monster and a new room:
                            reload = true;
                            break;

                        case "P":
                            Console.WriteLine("Player Info");
                            //TODO print player info here
                            break;

                        case "M":
                            Console.WriteLine("Monster Info");
                            //TODO print monster info here
                            break;

                        case "X":                            
                        case "E":
                            Console.WriteLine("No one likes a quitter...");
                            //exit both loops
                            exit = true;
                            break;
                        default:
                            //invalid input.
                            Console.WriteLine("You've Chosen Poorly");
                            break;
                    }// end switch
                    #endregion

                    //TODO Check Player Life
                } while (!reload && !exit);
                //if exit = true, both loops will terminate.
                //If reload = true, only the inner loop will terminate.
            } while (!exit); //exit == false
            //TODO Display final score (bosses killed) handle exit messages and stuff
        }//end Main()
        //Custom method called GetRoom() ---> ref Magic 8 ball lab
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

            //Build a Random
            //Random rand = new Random();

            //select a random number from 0 to the last index of rooms.
            //int randIndex = rand.Next(rooms.Length);

            //retrieve the value of that index into a string variable
            //string room = rooms[randIndex];

            //return that room to the Main()
            //return room;            //Refactoring means rewriting code to be more concise, readable, or performant:            //return rooms[new Random().Next(rooms.Length)];
        }
    }//end class
}//end namespace

//Dungeon:
//Handle source control if applicable//add a Class Library project called DungeonLibrary//Add a character class//Add a Weapon class//In ConsoleApp, add a TestHarness.cs with a SVM to test your creations without affecting the program.cs