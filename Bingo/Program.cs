/*TODO
 * [ ] Track bingo balls drawn in a two dimensional array
 * [x] Display status of all balls on the console
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
        //make this a global variable
        static bool[,] drawnBalls = new bool[5,15];
        static void Main(string[] args)
        {

            //drawnBalls[1, 0] = true;
            //drawnBalls[4, 14] = true;
            //drawnBalls[0, 0] = true;
            //drawnBalls[2, 5] = true;
            //drawnBalls[4, 13] = true;

            do
            {
                Console.Clear();
                ShowDisplay();
                DrawBall();
                Console.ReadLine(); //Unexpected function. If it was Console.Read() it will print two balls. Not sure why.
            } while (true);
            



            //pause
            Console.Read();
        }

        static void ShowDisplay()
        {
            int padding = 3;
            int prettyNumber;
            string placeHolder = "";
            string currentRow = "";
            string collumnSeparator = "  |";
            string[] heading = { "B", "I", "N", "G", "O" };
            foreach (string thing in heading)
            {
                Console.Write(thing.PadLeft(padding) + collumnSeparator);
            }
            Console.WriteLine();

            //Pring the rest of the rows
            for (int number = 1; number <= 15; number++)
            {
                //assemble the row
                for (int letter = 0; letter < 5; letter++)
                {
                    if (drawnBalls[letter, number - 1])
                    {
                        prettyNumber = number + (letter * 15); //number is the row by row offset. letter x 15 is the collumn by collumn offset
                        currentRow += prettyNumber.ToString().PadLeft(padding) + collumnSeparator;

                    }
                    else
                    {
                        currentRow += placeHolder.PadLeft(padding) + collumnSeparator;

                    }
                }
                Console.WriteLine(currentRow);
                currentRow = ""; //reset the variable
            }
        }
        static void DrawBall()
        {
            int letter = 0, number = 0;
            do
            {
                letter = RandomNumberZeroTo(4);
                number = RandomNumberZeroTo(14);

            } while (drawnBalls[letter, number]);

            drawnBalls[letter, number] = true;
        }
        /// <summary>
        /// Get a random integer from 0 to max of your choice inclusive
        /// </summary>
        /// <param name="max"></param>
        /// <returns>integer</returns>
        static private int RandomNumberZeroTo(int max)
        {
            int range = max + 1; //make max inclusive
            Random rand = new Random();
            return rand.Next(range);
            
        }
    }
}
