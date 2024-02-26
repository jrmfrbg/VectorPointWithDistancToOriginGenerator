using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Point with specific distance to origin generator by jrm");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Please enter distance to origin (ONLY non decimal numbers)");
        Console.ForegroundColor= ConsoleColor.White;
        string distanceString = Console.ReadLine();
        int distance = int.Parse(distanceString);
        int pointCount = 0;

        for (double x = -(distance); x <= distance; x += 0.01)
        {
            for (double y = -(distance); y <= distance; y += 0.01)
            {
                for (double z = -(distance); z <= distance; z += 0.01)
                {

                    if (Math.Round(x * x + y * y + z * z, 2) == distance * distance)
                    {
                        pointCount++;
                        Console.WriteLine($"Point {pointCount}: ({x:F2}, {y:F2}, {z:F2})");
                    }
                }
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Total points with distance {distanceString} LE to origin generated: {pointCount}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("type exit to exit");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        string exit = Console.ReadLine();
        if (exit == "exit")
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
            Environment.Exit(0);

        }
        
    }
}
