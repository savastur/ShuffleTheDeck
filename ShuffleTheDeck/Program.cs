/* To Do
 * [x] Create an array of each suit
 * [x] Diamnond suit
 * [x] Clubs suit
 * [x] Hearts suit
 * [x] Spades suit
 * [x] Create a display to show 52 cards 
 * [] Create an intial display with cards in order
*/
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShuffleTheDeck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C = Clubs, D = Diamonds, H = Hearts, S = Spades");
            //Enter
            Console.WriteLine();
            Display();
            Console.Read();
        }
        static void Display()
        {
            string cardIndex = "";
            string[] index = { "C", "D", "H", "S" };
            string[] cards = new string[12];
            cards[0] = "A";
            cards[1] = "2";
            cards[2] = "3";
            cards[3] = "4";
            cards[4] = "5";
            cards[5] = "6";
            cards[6] = "7";
            cards[7] = "9";
            cards[8] = "10";
            cards[9] = "J";
            cards[10] = "Q";
            cards[11] = "K";
            // Card display
            for (int row = 0; row < 13; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    cardIndex = index[RandomCard(3)];
                    string card = DrawCardValue(cardIndex);
                    Console.Write(card.PadLeft(4) + " |");
                }
                    Console.WriteLine();
            }
        }
        static private int RandomCard(int max)
        {
            int range = (max + 1); //Max is inclusive
            Random number = new Random();
            return number.Next(range);
        }
        static string DrawCardValue(string cardValue)
        {
            string[] cardvalues = new string[12];
            
            int number = 0;
            number = RandomCard(12);
            cardvalues[0] = "A";
            cardvalues[1] = "2";
            cardvalues[2] = "3";
            cardvalues[3] = "4";
            cardvalues[4] = "5";
            cardvalues[5] = "6";
            cardvalues[6] = "7";
            cardvalues[7] = "9";
            cardvalues[8] = "10";
            cardvalues[9] = "J";
            cardvalues[10] = "Q";
            cardvalues[11] = "K";
            string cardSum = cardvalues [number] + cardValue;
            return cardSum;
        }
    }
}
