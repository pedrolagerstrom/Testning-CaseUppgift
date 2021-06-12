using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Settings
    {
        public static string[] playerCards = new string[12];
        public static string hitOrStay = "";
        public static int total = 0, count = 1, dealerTotal = 0;
        public static Random cardRandomizer = new Random();


        public static void Setup()
        {
            dealerTotal = cardRandomizer.Next(15, 22);
            playerCards[0] = Cards.Deal();
            playerCards[1] = Cards.Deal();

            if (total.Equals(21))
            {
                Console.WriteLine("Welcome to Blackjack! You were dealed " + playerCards[0] + " and " + playerCards[1] + ". \nCongrats! You got Blackjack! \nWould you like to play again? y/n");
                Game.PlayAgain();
            }
            else
            {
                do
                {
                    Console.WriteLine("Welcome to Blackjack! You were dealed " + playerCards[0] + " and " + playerCards[1] + ". \nYour total is " + total + ".\nWould you like to hit or stay?");
                    hitOrStay = Console.ReadLine().ToLower();
                }
                while (!hitOrStay.Equals("h") && !hitOrStay.Equals("s"));
                Game.Start();
            }            
        }        
    }
}
