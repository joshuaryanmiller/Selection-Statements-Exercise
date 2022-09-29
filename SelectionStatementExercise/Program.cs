using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var favNumber = 7;
        var userGuess = 0;
        var closeAbove = favNumber + 1;
        var closeBelow = favNumber - 1;
        int v;
        
        Console.WriteLine("Guess my favorite number between 1 & 10.");
        do
        {
            do
            {
                if (!int.TryParse(Console.ReadLine(), out v))
                {
                    Console.WriteLine("Type only positive numbers greater than zero!");
                }
                else if (v == 0)
                {
                    Console.WriteLine("Type only positive numbers greater than zero!");
                }
            } while (v == 0);
            userGuess = v;
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