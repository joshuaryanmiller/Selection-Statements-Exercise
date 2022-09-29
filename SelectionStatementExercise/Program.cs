using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What was your favorite subject in high school?");

        string? userSubject = Console.ReadLine();

        switch (userSubject)
        {
            case "Math":
                Console.WriteLine("Math is cool!");
                break;
            case "English":
                Console.WriteLine("To be or not to be...");
                break;
            case "Physics":
                Console.WriteLine("E=MC^2...");
                break;
            case "Chemistry":
                Console.WriteLine("Do you remember the periodic table of elements?");
                break;
            case "P.E.":
                Console.WriteLine("Isn't that everybody's favorite?");
                break;
            default:
                Console.WriteLine("What school did you go to?!?!!");
                break;

        }
    }
}