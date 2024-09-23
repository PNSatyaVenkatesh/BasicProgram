using System;

public class Rectangle
{
        static void Main(string[] args)
        {
            onsole.Write("Enter the Length:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Breadth:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Area:" + (x * y));
            Console.Write("Perimeter:" + 2 * (x + y));
        }
    }
