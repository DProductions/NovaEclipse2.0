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
            Console.SetCursorPosition(0, 10);

            // Display the instructions
            Console.WriteLine("Instructions:");
            Console.WriteLine("Press any key to start the game.");
            Console.WriteLine("Use arrow keys to move the player.");
            Console.WriteLine("Press 'Q' to quit the game.");

            // Wait for user input
            Console.ReadKey();

            Menu menu = new Menu();
            menu.Display();
            
        }
    }
}
