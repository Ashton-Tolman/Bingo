/*TODO
 * [ ] track bingo balls drawn in a two dimensional array
 * [ ] display status of all balls on the console
 * [ ] Clear all drawn balls to start a new game
 * [ ] Let the user quit 
 * [ ] Draw a random ball
 * [ ] Get a random number to determine ball letter
 * [ ] Get a random number to determine ball number
 * [ ] Check if ball has already been drawn. No: mark as drawn, yes: draw another
 */
namespace Bingo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] drawnBalls = new bool[5,15];

            drawnBalls[1, 0] = true;
            ShowDisplay();



            //pause
            Console.Read();
        }

        static void ShowDisplay()
        {
            int padding = 2;
            string[] heading = { "B", "I", "N", "G", "O" };
            foreach (string thing in heading)
            {
                Console.Write(thing.PadLeft(padding) + " |");
            }

            //Pring the rest of the rows
            for (int letter = 0; letter < 5; letter++)
            {
                Console.Write(letter.ToString().PadLeft(padding) + " |");
            }
        }
    }
}
