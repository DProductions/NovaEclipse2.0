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
            Menu menu = new Menu();

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
                    menu.DisplayRooms();
                }
                else if (option == 2)
                {
                    menu.DisplayWeapons();
                }
                else if (option == 3)
                {
                    menu.DisplayPotions();
                }
                else if (option == 4)
                {
                    menu.DisplayTreasure();
                }
                else if (option == 5)
                {
                    menu.DisplayItems();
                }
>>>>>>>>> Temporary merge branch 2
                else if (option == 6)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
