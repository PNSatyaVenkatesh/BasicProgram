using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Loop
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the n value: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }
}

internal class Loop
{
    public static void Main(String[] args)
    {
        int sum = 0;
        int c_even = 0;
        int c_odd = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
                c_even++;
            else
                c_odd++;
            sum += i;

        }
        Console.WriteLine("Sum of numbers 1 to 100 :" + sum);
        Console.WriteLine("Average of numbers 1 to 100" + sum / 100);
        Console.WriteLine("No.of even numbers :" + c_even);
        Console.WriteLine("No.of odd numbers : " + (c_odd));

    }
}

internal class Loop
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the start value:");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter the end value:");
        int end = int.Parse(Console.ReadLine());
        if (start > end)
        {
            for (int i = start; i >= end; i--)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            for (int i = start; i < end; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}

internal class Loop
{

    public static void Main(String[] args)
    {
        Console.Write("Enter which table you want :");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Multiplication Table for " + num);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " * " + i + " = " + (num * i));
        }

    }
}

internal class Loop
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the number: ");
        int n = int.Parse(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        Console.WriteLine($"Factorial of {n} is : " + fact);
    }
}

internal class Loop
{
    public static void Main(String[] args)
    {
        Console.Write("Enter Base Value :");
        int base1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Power Value :");
        int power = int.Parse(Console.ReadLine());
        int higher = 1;
        for (int i = 1; i <= power; i++)
        {
            higher *= base1;
        }
        Console.WriteLine($"{base1} power {power} is: " + higher);

    }
}

internal class Loop
{
    public static void Main(String[] args)
    {
        for (; ; )
        {
            Console.WriteLine("Satya");
        }

        while (true)
        {
            Console.Write("Satya");
        }

        do
        {
            Console.Write("Satya");
        }
        while (true);

    }
}

internal class Loop
{

    public static void Main(String[] args)
    {
        Console.Write("Enter the number :");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose any one option: \n1.Square \n2.Cube");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Sqaure of " + i + " :" + (i * i));
            }
        }
        else
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Cube of " + i + " :" + (i * i * i));
            }
        }
    }
}


internal class Loop
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Numbers divisble by 7 & 5 between 1 to 1000 are :");
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 5 == 0 && i % 7 == 0)
                Console.Write(i + " ");
        }
    }
}

internal class Loop
{
    public static void Main(String[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Multiplication Table for {i}:");
            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine(i + " * " + j + " = " + (i * j));
            }
        }
    }
}


internal class Loop
{
    public static void Main(String[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");

            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}

internal class Loop
{
    public static void Main(String[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 5 == 0)
                break;
            Console.WriteLine(i);
        }
    }
}

internal class Loop
{
    public static void Main(String[] args)
    {
        for (int i = 1; i < 100; i++)
        {
            if (i % 5 == 0)
                continue;
            Console.Write(i + " ");
        }
    }
}




