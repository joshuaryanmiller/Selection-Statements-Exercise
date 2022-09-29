namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 7;
            int userGuess = 0;
            int closeAbove = favNumber + 1;
            int closeBelow = favNumber - 1;

            Console.WriteLine("Guess my favorite number between 1 & 10.");
            do
            {
                userGuess = int.Parse(Console.ReadLine());
                if (userGuess == favNumber)
                {
                    Console.WriteLine("Great guess!");
                }
                else if (userGuess == closeAbove)
                {
                    Console.WriteLine("Close!");
                }
                else if (userGuess == closeBelow)
                {
                    Console.WriteLine("Close!");
                }
                else if (userGuess < favNumber)
                {
                    Console.WriteLine("Too low.");
                }
                else if (userGuess > favNumber)
                {
                    Console.WriteLine("Too high.");
                }
                else
                {
                    Console.WriteLine("Nevermind.");
                }
            } while (userGuess != favNumber);
        }
    }
}