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

        Thread lineThread = new Thread(AnimateLine);
        lineThread.Start();

        FlashText(text, interval, flashDuration);

        lineThread.Join(); // Wait for the line thread to finish before exiting

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

    static void AnimateLine()
    {
        while (true)
        {
            int top = new Random().Next(Console.WindowHeight);
            int left = new Random().Next(Console.WindowWidth);
            int length = new Random().Next(10, 30);

            ConsoleColor color = GetRandomConsoleColor();
            DrawLine(top, left, length, color);

            Thread.Sleep(100);
        }
    }

    static void DrawLine(int top, int left, int length, ConsoleColor color)
    {
        Console.SetCursorPosition(left, top);
        Console.ForegroundColor = color;

        for (int i = 0; i < length; i++)
        {
            Console.Write("-");
        }
    }
}