using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Game
    {
        public static void Start()
        {
            if (Settings.hitOrStay.Equals("h"))
            {
                Hit();
            }
            else if (Settings.hitOrStay.Equals("s"))
            {
                if (Settings.total > Settings.dealerTotal && Settings.total <= 21)
                {
                    Console.WriteLine("\nCongrats! You won the game! The dealer's total was " + Settings.dealerTotal + ".\nWould you like to play again? y/n");
                    PlayAgain();
                }
                else if (Settings.total < Settings.dealerTotal || Settings.total >= 22)
                {
                    Console.WriteLine("\nSorry, you lost! The dealer's total was " + Settings.dealerTotal + ".\nWould you like to play again? y/n");
                    PlayAgain();
                }
            }
        }

        public static void Hit()
        {
            Settings.count += 1;
            Settings.playerCards[Settings.count] = Cards.Deal();
            Console.WriteLine("\nYou were dealed a " + Settings.playerCards[Settings.count] + ".\nYour new total is " + Settings.total + ".");
            if (Settings.total.Equals(21))
            {
                Console.WriteLine("\nYou got Blackjack! The dealer's total was " + Settings.dealerTotal + ".\nWould you like to play again? y/n");
                PlayAgain();
            }
            else if (Settings.total > 21)
            {
                Console.WriteLine("\nYou busted, therefore you lost. Sorry. The dealer's total was " + Settings.dealerTotal + ".\nWould you like to play again? y/n");
                PlayAgain();
            }
            else
            {
                do
                {
                    Console.WriteLine("\nWould you like to hit or stay?");
                    Settings.hitOrStay = Console.ReadLine().ToLower();
                }
                while (!Settings.hitOrStay.Equals("h") && !Settings.hitOrStay.Equals("s"));
                Start();
            }
        }

        public static void PlayAgain()
        {
            string playAgain = "";
            do
            {
                playAgain = Console.ReadLine().ToLower();
            }
            while (!playAgain.Equals("y") && !playAgain.Equals("n"));
            if (playAgain.Equals("y"))
            {
                Console.WriteLine("\nPress enter to restart the game!");
                Console.ReadLine();
                Console.Clear();
                Settings.dealerTotal = 0;
                Settings.count = 1;
                Settings.total = 0;
                Settings.Setup();
            }
            else if (playAgain.Equals("n"))
            {
                Console.WriteLine("\nPress enter to close Blackjack.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
