using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {


        // Handle one side of a round of combat (one attack)
        public static void DoAttack(Character attacker, Character defender)
        {

            Thread.Sleep(400);
            //20% chance to do a thing:
            // 1-100 anthing less then 20 will succeed
            int chance = attacker.CalcHitChance() - defender.CalcBlock();
            int roll = new Random().Next(1, 101);
            // the attacker hits if the "roll" is less then the adjusted hit chance.
            if (roll >= chance)
            {
                // attacker missed
                Console.WriteLine($"{attacker.Name} missed!");
                return;
            }

            //calculate the damage:
            int damage = attacker.CalcDamage();
            //remove life from the defender
            defender.Life -= damage;
            // show the results to the console.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damage}!");
            if (defender.GetType() == typeof(SkeletonKing))
            {
                SkeletonKing sk = (SkeletonKing)defender;
                int thornDamage = sk.CalcSpecial();
                attacker.Life -= thornDamage;
                Console.WriteLine($"{attacker.Name} has taken {thornDamage} thorns damage.");
            }
            if (attacker.GetType() == typeof(Butcher))
            {
                Console.WriteLine($"{attacker.Name} has leached 5 Health from you");
            }
            if (defender.GetType() == typeof(Diablo))
            {
                Diablo dk = (Diablo)defender;
                int immolation = dk.CalcSpecial();
                attacker.Life -= immolation;
                Console.WriteLine($"{defender.Name} burns the gound beneath you for {immolation} damage.");
            }
            Console.ResetColor();

        }//end DoAttack()
        // Returns true if the monster has died, False if the monster is still alive.
        public static bool DoBattle(Player player, Monster monster)
        {
            int playerInt = new Random().Next(1, 101);
            int monsterInt = new Random().Next(1, 101);
            #region Expansions
            //Possible Expansion: Give certain character races or characters with a certain weapon an advantage
            if (monster.GetType() == typeof (QuillBoar))
            {
                Console.WriteLine($" {monster.Name} shoots multiple quills!");
                Combat.DoAttack( monster,player);
                Combat.DoAttack(monster, player);
                Combat.DoAttack(monster, player);

            }

            //Consider adding an "Initiative" property to Character
            //Then check the Initiative to determine who attacks first
            if (playerInt >= monsterInt)
            {
                DoAttack(player, monster);
                if (monster.Life > 0)
                {
                    Thread.Sleep(400);
                    DoAttack(monster, player);
                    // return false;// monster is still alive
                }
            }
            else
            {
                DoAttack(monster, player);
                if (player.Life > 0)
                {
                    Thread.Sleep(400);
                    DoAttack(player, monster);
                    //return monster.Life <= 0;// monster is still alive
                }
            }
            #endregion
            ;
            //pause the app to make it look like something is happening
            //DoAttack(player, monster);
            //if (monster.Life > 0)
            //{
            //    Thread.Sleep(400);
            //    DoAttack(monster, player);
            //    return false;// monster is still alive
            //}
            #region COmbat rewards
            //player.Score++;
            //Healing logice (player.Life += 5)

            //Loot drops (Note: this would require an Item class as well as an Inventory Property for Both Player and Monster
            // Player List<Item>)
            //Item rubyNecklace = new Item("Ruby Necklace", "Increases Max Life", MaxLife, 10);
            //inventory.add(rubyNecklace);
            //Console.WriteLine($"{player.Name} received {rubyNecklace.Name}!");
            //Console.WriteLine("{0}", rubyNecklace);

            #endregion

            if (monster.Life > 0)
            {
                return false;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYou killed {monster.Name}!");
            if (monster.GetType() == typeof(SkeletonKing))
            {
                var mon = (SkeletonKing)monster;
                var loot = mon.DropLoot();
                Console.WriteLine($"{monster.Name} has dropped {loot.ItemName}");
                player.Inventory.Add(loot);


                player.RefreshAfterLooting();
            }
            if (monster.GetType() == typeof(Butcher))
            {
                var mon = (Butcher)monster;
                var loot = mon.DropLoot();
                
                Console.WriteLine($"{monster.Name} has dropped {loot.ItemName}");
                player.Inventory.Add(loot);


                player.RefreshAfterLooting();
            }

            if (monster.GetType() == typeof(QuillBoar))
            {
                var mon = (QuillBoar)monster;
                var loot = mon.DropLoot();
                Console.WriteLine($"{monster.Name} has dropped {loot.ItemName}");
                player.Inventory.Add(loot);


                player.RefreshAfterLooting();
            }
            if (monster.GetType() == typeof(Skeleton))
            {
                var mon = (Skeleton)monster;
                var loot = mon.DropLoot();
                Console.WriteLine($"{monster.Name} has dropped {loot.ItemName}");
                player.Inventory.Add(loot);


                player.RefreshAfterLooting();
            }
            if (monster.GetType() == typeof(Zombie))
            {
                var mon = (Zombie)monster;
                var loot = mon.DropLoot();
                Console.WriteLine($"{monster.Name} has dropped {loot.ItemName}");
                player.Inventory.Add(loot);


                player.RefreshAfterLooting();
            }
            if (monster.GetType() == typeof(Diablo))
            {
                var mon = (Diablo)monster;
                var loot = mon.DropLoot();
                Console.WriteLine($"{monster.Name} has dropped {loot.ItemName}");
                player.Inventory.Add(loot);


                player.RefreshAfterLooting();
            }
            Console.ResetColor();
            player.Score++;
            return true;//Monster has died!
        }

        // Handle one full round of Combat (Player attack, then Monster attack)



    }
}
