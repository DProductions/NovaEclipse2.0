/**
* 2 APR 2023
* CSC 153
* Daniel Parks
* Nova Eclipse
* 
* SPRINT 4 completed. 
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using neClassLibrary1;

namespace NovaEclipse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instancce of Menu , 
            Menu menu = new Menu();

            // While state ment to continually repeat menue
            while (true)
            {
                // Display menue, save input as 'int option'
                int option = menu.Display();

                //Call method for each selection
                if (option == 1)
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

                // Selecting '6' exits program
                else if (option == 6)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                // Else statement catches invalid responses
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                }
            }
        }
    }
}