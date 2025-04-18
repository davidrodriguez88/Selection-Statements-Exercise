namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 7;
            int userInput = 0;

            while (userInput != favNumber)
            {
                Console.WriteLine("Guess my favorite number (1-10):");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("You guessed it!!!");
                }
            }
        }
    }
}
