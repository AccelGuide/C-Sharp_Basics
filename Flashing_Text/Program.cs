using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Title = "Flashing Text";

        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();

        string text = "C# learning in silence is Boring!";
        int interval = 500; // in milliseconds
        int flashDuration = 5000; // in milliseconds

        Console.WriteLine("Press any key to start flashing text...");
        Console.ReadKey();
        Console.Clear();

        FlashText(text, interval, flashDuration);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void FlashText(string text, int interval, int flashDuration)
    {
        Console.CursorVisible = false;
        bool isFlashed = false;

        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalMilliseconds < flashDuration)
        {
            if (isFlashed)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else
            {
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2);
            Console.Write(text);

            Thread.Sleep(interval);
            isFlashed = !isFlashed;
        }

        Console.ResetColor();
        Console.Clear();
    }

    static ConsoleColor GetRandomConsoleColor()
    {
        ConsoleColor[] consoleColors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        return consoleColors[new Random().Next(consoleColors.Length)];
    }
}