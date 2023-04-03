using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace neClassLibrary1
{
    public class Menu
    {
        public void Display()
        {
            bool isSelected = false;
            while (!isSelected)
            {
                Console.WriteLine("- - - - - Menu - - - - -\n" +
                                  "Please make a selection\n" +
                                  "   1. Display Rooms\n" +
                                  "   2. Display Weapons\n" +
                                  "   3. Display Potion\n" +
                                  "   4. Display Treasure\n" +
                                  "   5. Display Items\n" +
                                  "   6. Exit-\n" +
                                  "- - - - - - - - - - - -");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayRooms();
                        break;

                    case "2":
                        DisplayWeapons();
                        break;

                    case "3":
                        DisplayPotions();
                        break;

                    case "4":
                        DisplayTreasure();
                        break;

                    case "5":
                        DisplayItems();
                        break;

                    case "6":
                        isSelected = true;
                        break;

                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        break;
                }
            }
        }

        private void DisplayRooms()
        {
            Console.WriteLine(
                "\n" +
                "                                     Back Door                   \n" +
                "________________________________________     __________________\n" +
                "|   My      |   Spare   |             |                        |\n" +
                "| Bedroom   |   Room    |   Study     |         Living Room    |\n" +
                "|_________  |_________  |   __________|                        |\n" +
                "| BTHRM1 |           Hallway                                   |\n" +
                "|_____________________ ________    __                          |\n" +
                "                      |             |                          |\n" +
                "                      |                           ______       |\n" +
                "                      |   Kitchen       Dining    |       |    |\n" +
                "                      |             |    Room     | BTHRM2|    |\n" +
                "                      |_____________|_____________|_______|    |\n" +
                "                                                       Front Door\n" +
                "\n");

            // read text file for rooms
            string[] rooms = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\rooms.txt");
            Console.WriteLine("\n");
            Console.WriteLine($"Room 1: {rooms[0]}");
            Console.WriteLine($"Room 2: {rooms[1]}");
            Console.WriteLine($"Room 3: {rooms[2]}");
            Console.WriteLine($"Room 4: {rooms[3]}");
            Console.WriteLine($"Room 5: {rooms[4]}");
            Console.WriteLine($"Room 6: {rooms[5]}");
            Console.WriteLine($"Room 7: {rooms[6]}");
            Console.WriteLine($"Room 8: {rooms[7]}");
            Console.WriteLine($"Room 9: {rooms[8]}");
        }

        private void DisplayWeapons()
        {
            // read text file for weapons
            string[] weapons = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\weapons.txt");
            Console.WriteLine("\n");
            Console.WriteLine($"Weapon 1: {weapons[0]}");
            Console.WriteLine($"Weapon 2: {weapons[1]}");
            Console.WriteLine($"Weapon 3: {weapons[2]}");
            Console.WriteLine($"Weapon 4: {weapons[3]}");

        }
        private void DisplayPotions()
        {
            // read text file for potions
            string[] potions = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\potions.txt");
            Console.WriteLine("\n");
            Console.WriteLine($"Potion 1: {potions[0]}");
            Console.WriteLine($"Potion 2: {potions[1]}");

        }

        private void DisplayTreasure()
        {
            // read text file for treasure
            string[] treasure = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\treasure.txt");
            Console.WriteLine("\n");
            Console.WriteLine($"Treasure 1: {treasure[0]}");
            Console.WriteLine($"Treasure 2: {treasure[1]}");
            Console.WriteLine($"Treasure 3: {treasure[2]}");
            Console.WriteLine($"Treasure 4: {treasure[3]}");

        }

        private void DisplayItems()
        {
            // read text file for items
            string[] items = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\items.txt");
            Console.WriteLine("\n");
            Console.WriteLine($"Item 1: {items[0]}");
            Console.WriteLine($"Item 2: {items[1]}");
            Console.WriteLine($"Item 3: {items[2]}");
            Console.WriteLine($"Item 4: {items[3]}");

        }
    }



    public class Fight
    {
        private int playerHP = 100;
        private int mobHP = 100;

        public void Combat()
        {
            Console.WriteLine("Player HP: " + playerHP);
            Console.WriteLine("Mob HP: " + mobHP);

            while (playerHP > 0 && mobHP > 0)
            {
                // Roll a 1D12 dice for damage calculation
                Random random = new Random();
                string diceRoll = "1d12";
                string[] diceTokens = diceRoll.Split('d');
                int diceCount = int.Parse(diceTokens[0]);
                int diceSize = int.Parse(diceTokens[1]);
                int totalDamage = 0;
                for (int i = 0; i < diceCount; i++)
                {
                    totalDamage += random.Next(1, diceSize + 1);
                }

                // Subtract damage from HP
                mobHP -= totalDamage;

                Console.WriteLine("Player attacks for " + totalDamage + " damage");
                Console.WriteLine("Mob HP: " + mobHP);

                if (mobHP <= 0)
                {
                    Console.WriteLine("Player wins!");
                    return;
                }

                // Roll a 1D12 dice for damage calculation
                diceRoll = "1d12";
                diceTokens = diceRoll.Split('d');
                diceCount = int.Parse(diceTokens[0]);
                diceSize = int.Parse(diceTokens[1]);
                totalDamage = 0;
                for (int i = 0; i < diceCount; i++)
                {
                    totalDamage += random.Next(1, diceSize + 1);
                }

                // Subtract damage from HP
                playerHP -= totalDamage;

                Console.WriteLine("Mob attacks for " + totalDamage + " damage");
                Console.WriteLine("Player HP: " + playerHP);

                if (playerHP <= 0)
                {
                    Console.WriteLine("Mob wins!");
                    return;
                }
            }
        }
    }
}
