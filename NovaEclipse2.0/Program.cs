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
<<<<<<<<< Temporary merge branch 1
            Console.SetCursorPosition(0, 10);

            // Display the instructions
            Console.WriteLine("Instructions:");
            Console.WriteLine("Press any key to start the game.");
            Console.WriteLine("Use arrow keys to move the player.");
            Console.WriteLine("Press 'Q' to quit the game.");

            // Wait for user input
            Console.ReadKey();
=========
>>>>>>>>> Temporary merge branch 2

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