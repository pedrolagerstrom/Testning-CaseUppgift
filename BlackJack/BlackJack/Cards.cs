using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Cards
    {
        public static string DealCards()
        {
            string Card = "";
            int cards = Settings.cardRandomizer.Next(1, 14);
            switch (cards)
            {
                case 1:
                    Card = "Two"; Settings.total += 2;
                    break;
                case 2:
                    Card = "Three"; Settings.total += 3;
                    break;
                case 3:
                    Card = "Four"; Settings.total += 4;
                    break;
                case 4:
                    Card = "Five"; Settings.total += 5;
                    break;
                case 5:
                    Card = "Six"; Settings.total += 6;
                    break;
                case 6:
                    Card = "Seven"; Settings.total += 7;
                    break;
                case 7:
                    Card = "Eight"; Settings.total += 8;
                    break;
                case 8:
                    Card = "Nine"; Settings.total += 9;
                    break;
                case 9:
                    Card = "Ten"; Settings.total += 10;
                    break;
                case 10:
                    Card = "Jack"; Settings.total += 10;
                    break;
                case 11:
                    Card = "Queen"; Settings.total += 10;
                    break;
                case 12:
                    Card = "King"; Settings.total += 10;
                    break;
                case 13:
                    Card = "Ace"; Settings.total += 11;
                    break;
                default:
                    Card = "2"; Settings.total += 2;
                    break;
            }
            return Card;
        }
    }
}
