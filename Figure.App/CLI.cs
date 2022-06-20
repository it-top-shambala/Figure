namespace Figure.App;

public static class CLI
{
    private static void ShowEndL(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    private static void Show(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.Write(message);
        Console.ResetColor();
    }

    public static void ShowInfo(string message)
    {
        ShowEndL(message, ConsoleColor.Blue);
    }
    public static void ShowError(string message)
    {
        ShowEndL(message, ConsoleColor.Red);
    }

    public static string Input(string message)
    {
        Show(message, ConsoleColor.DarkGreen);
        return Console.ReadLine();
    }
}