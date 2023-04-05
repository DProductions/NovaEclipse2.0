/**
* 23 APR 2023
* CSC 153
* Daniel Parks
* Nova Eclipse

* SPRINT 4 completed. 
*/



using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using neClassLibrary1;


namespace RoomNavigation
{
    class Program
    {

                public static void Locked()
    {
Console.SetWindowPosition(0, 0);

Console.WriteLine("Welcome to Nova Eclipse.");
Console.WriteLine("Press 'w' to move forward.");
Console.WriteLine("Press 's' to move backwards.");
Console.WriteLine("Press'z' for Treasures, 'c' for Weapons, 'e' for Items, 'f' for potions and 'x' for Mobs.");
Console.WriteLine("Press 'q' to quit.");

            }

        static void Main(string[] args)

        {

            // Read the files and create arrays
            string[] rooms = File.ReadAllLines(@"..\..\..\..\NovaEclipse2.0\NovaEclipse2.0\Variables\rooms.txt");
  


            int currentRoomIndex = 0;
            Locked();
            Console.WriteLine($"Welcome to {rooms[currentRoomIndex]}!\n");

            while (true)
            {


                // Read user input
                ConsoleKeyInfo key = Console.ReadKey(true);

                // Process user input
                switch (key.KeyChar)
                {
                    case 'w':
                    case 'W':
                        if (currentRoomIndex == rooms.Length - 1)
                        {
                            Console.WriteLine("You cannot go further. There are no more rooms.");
                        }
                        else
                        {
                            currentRoomIndex++;
                            Console.WriteLine($"You moved to {rooms[currentRoomIndex]}.");
                        }
                        break;

                    case 's':
                    case 'S':
                        if (currentRoomIndex == 0)
                        {
                            Console.WriteLine("You cannot go back. You are already in the first room.");
                        }
                        else
                        {
                            currentRoomIndex--;
                            Console.WriteLine($"You moved to {rooms[currentRoomIndex]}.");
                        }
                        break;

                    case 'q':
                    case 'Q':
                        Console.WriteLine("Exiting program.");
                        return;
                    case 'c':
                    case 'C':
                        Menu.DisplayWeapons();
                        break;
                    case 'f':
                    case 'F':
                        Menu.DisplayPotions();
                        break;
                    case 'z':
                    case 'Z':
                        Menu.DisplayTreasure();
                        break;
                    case 'e':
                    case 'E':
                        Menu.DisplayItems();
                        break;
                    case 'x':
                    case 'X':
                        Menu.DisplayMobs();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
