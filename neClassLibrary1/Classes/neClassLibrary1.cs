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
        // Display() method displays menue and saves it as 'int option' 
        public int Display()

      
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

            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            return option;
        }

            public void DisplayRooms()
        {
            // read text file for weapons
            string[] weapons = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\rooms.txt");
            Console.WriteLine("\n");
            Console.WriteLine($"Weapon 1: {weapons[0]}");
            Console.WriteLine($"Weapon 2: {weapons[1]}");
            Console.WriteLine($"Weapon 3: {weapons[2]}");
            Console.WriteLine($"Weapon 4: {weapons[3]}");
            Console.WriteLine($"Weapon 5: {weapons[4]}");
            Console.WriteLine($"Weapon 6: {weapons[5]}");
            Console.WriteLine($"Weapon 7: {weapons[6]}");
            Console.WriteLine($"Weapon 8: {weapons[7]}");
            Console.WriteLine($"Weapon 9: {weapons[8]}");

        }

            public void DisplayWeapons()
        {
            // read text file for weapons
            string[] weapons = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\weapons.txt");
            Console.WriteLine("\n");
            Console.WriteLine($"Weapon 1: {weapons[0]}");
            Console.WriteLine($"Weapon 2: {weapons[1]}");
            Console.WriteLine($"Weapon 3: {weapons[2]}");
            Console.WriteLine($"Weapon 4: {weapons[3]}");

        }
        public void DisplayPotions()
        {
            // read text file for potions
            string[] potions = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\potions.txt");
            Console.WriteLine("\n");
            Console.WriteLine($"Potion 1: {potions[0]}");
            Console.WriteLine($"Potion 2: {potions[1]}");

        }

        public void DisplayTreasure()
        {
            // read text file for treasure
            string[] treasure = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\treasure.txt");
            Console.WriteLine("\n");
            Console.WriteLine($"Treasure 1: {treasure[0]}");
            Console.WriteLine($"Treasure 2: {treasure[1]}");
            Console.WriteLine($"Treasure 3: {treasure[2]}");
            Console.WriteLine($"Treasure 4: {treasure[3]}");

        }

        public void DisplayItems()
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
}
