using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace neFight
{
    public class Fight
    {
        private int playerHP = 100;
        private int mobHP = 100;

        public void fight1D12()
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
