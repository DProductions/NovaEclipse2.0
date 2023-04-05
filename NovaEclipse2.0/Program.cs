/**
* 2 APR 2023
* CSC 153
* Daniel Parks
* Nova Eclipse
* 04 April 2023
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
            Menu menu = new Menu();

            while (true)
            {
                int option = menu.Display();

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
                else if (option == 6)
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                }
            }
        }
    }
}