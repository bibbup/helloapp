namespace ConsoleApp1;

internal class Program
{
    private static void Main()
    {
        PrintHello();
    }

    private static void PrintHello()
    {
        Console.WriteLine("hello everyone");
        greetWhite();
        greetBlack();
    }

    private static void greetWhite()
    {
        Console.WriteLine("hello white");
    }

    private static void greetBlack()
    {
        Console.WriteLine("hello black");
    }
}
