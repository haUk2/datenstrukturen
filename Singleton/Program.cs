using Singleton;

class Program
{
    public static void Main(string[] args)
    {
        King Heinrich = King.getInstance();

        Heinrich.setName("Heinrich IV");

        Console.WriteLine(Heinrich.Angriffsbefehl());

        King Ludwig = King.getInstance();

        Ludwig.setName("Ludwig XIV");

        Console.WriteLine(Ludwig.Angriffsbefehl());

        Console.WriteLine(Heinrich.RueckzugsBefehl());

        Console.WriteLine("Program exit");

    }
}