/* To Do
 * [] Create an array of each suit
 * [] Diamnond suit
 * [] Clubs suit
 * [] Hearts suit
 * [] Spades suit
 * [x] Create a display to show 52 cards 
*/
using System.ComponentModel.DataAnnotations;

namespace ShuffleTheDeck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display();
            Console.Read();
        }
        static void Display()
        {
            string[] header = { "C", "D", "H", "S" };
            foreach (string s in header)
            {
                Console.Write(s.PadLeft(4) + " |");
            }
            Console.WriteLine();
            string location = "XX";
            for (int row = 0; row < 13; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    Console.Write(location.PadLeft(4) + " |");
                }
                    Console.WriteLine();
            }
        }
       
    }
}
