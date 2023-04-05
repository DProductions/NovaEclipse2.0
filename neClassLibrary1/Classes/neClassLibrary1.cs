/**
* 23 APR 2023
* CSC 153
* Daniel Parks
* Nova Eclipse

* SPRINT 4 completed. 
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace neClassLibrary1
{
    public class Menu
    {


        
        // Display() method displays menue and saves it as 'int option' 
        
        
        


            public void DisplayRooms()
        {
            // read text file for weapons
            string[] rooms = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\rooms.txt");
            Console.WriteLine("\n");
            Console.WriteLine($"Room 1: {rooms[0]}");
            Console.WriteLine($"Room 2: {rooms[1]}");
            Console.WriteLine($"Room 3: {rooms[2]}");
            Console.WriteLine($"Room 4: {rooms[3]}");
            Console.WriteLine($"Roomn 5: {rooms[4]}");
            Console.WriteLine($"Room 6: {rooms[5]}");
            Console.WriteLine($"Room 7: {rooms[6]}");
            Console.WriteLine($"Room 8: {rooms[7]}");
            Console.WriteLine($"Room 9: {rooms[8]}");
            Console.WriteLine("\n\n");

        }

           public static void DisplayWeapons()
        {
            string[] weapons = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\weapons.txt");
                            Console.WriteLine("Weapons are as follows:");
                        for (int i = 0; i < weapons.Length; i++)
                            {
                            Console.WriteLine(weapons[i]);
                            }

        }
        public static void DisplayPotions()
        {
         string[] potions = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\potions.txt");

                     Console.WriteLine("The potions are:");
                        for (int i = 0; i < potions.Length; i++)
                            {
                            Console.WriteLine(potions[i]);
                            }
        }

        public static void DisplayTreasure()
        {
            // read text file for treasure
            string[] treasure = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\treasure.txt");
                     Console.WriteLine("The treausres are:");
                        for (int i = 0; i < treasure.Length; i++)
                            {
                            Console.WriteLine(treasure[i]);
                            }

        }

        public static void DisplayItems()
        {
            // read text file for items
            string[] items = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\items.txt");
                            Console.WriteLine("The Items are:");
                            List<string> itemList = items.ToList();
                            int itemNum = 1;
                            foreach (string item in itemList)
                            {
                            Console.WriteLine($"Item {itemNum}: {item}");
                            itemNum++;
                            }

        }
        public static void DisplayMobs()
        {
            // read text file for Mobs
            string[] mob = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\mobs.txt");
                            List<string> mobList = mob.ToList();
                            int mobNum = 1;
                            foreach (string m in mobList)
                            {
                            Console.WriteLine($"Mob {mobNum}: {m}");
                            mobNum++;
                            }

        }

    
    }
}





    