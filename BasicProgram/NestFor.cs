using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class NestFor
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int temp = num;
            while (num > 0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num /= 10;
            }
            Console.WriteLine($"Reverse of the number {temp} : {rev}");
        }
    }
}

internal class NestFor
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                count++;
                break;
            }
        }
        if (count == 0)
        {
            Console.WriteLine(num + " is Prime");
        }
        else
        {
            Console.WriteLine(num + " is not Prime");
        }
    }
}

internal class NestFor
{
    public static void Main(string[] args)
    {
        for (int j = 1; j <= 100; j++)
        {
            int num = j; int count = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine(num + " is Prime");
            }
            else
            {
                Console.WriteLine(num + " is not Prime");
            }
        }
    }
}

internal class NestFor
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }
        if (sum == num)
        {
            Console.WriteLine(num + " is Perfect number");
        }
        else
        {
            Console.WriteLine(num + " is not Perfect number");
        }
    }
}

internal class NestFor
{
    public static void Main(string[] args)
    {
        for (int j = 1; j <= 100; j++)
        {
            int sum = 0; int num = j;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num + " is Perfect number");
            }
            else
            {
                Console.WriteLine(num + " is not Perfect number");
            }
        }
    }
}

internal class NestFor
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int sumOfDigits = 0;
        int productOfDigits = 1;
        int temp = num;

        while (temp > 0)
        {
            int digit = temp % 10;
            sumOfDigits += digit;
            productOfDigits *= digit;
            temp /= 10;
        }

        if (sumOfDigits == productOfDigits)
        {
            Console.WriteLine(num + " is a spy number.");
        }
        else
        {
            Console.WriteLine(num + " is not a spy number.");
        }
    }
}

internal class NestFor
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int sumOfDigits = 0;
        int temp = num;

        while (temp > 0)
        {
            sumOfDigits += temp % 10;
            temp /= 10;
        }

        if (num % sumOfDigits == 0)
        {
            Console.WriteLine(num + " is a Niven number.");
        }
        else
        {
            Console.WriteLine(num + " is not a Niven number.");
        }
    }
}

internal class NestFor
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int squaredNum = num * num;
        int sumOfDigits = 0;
        int temp = squaredNum;

        while (temp > 0)
        {
            sumOfDigits += temp % 10;
            temp /= 10;
        }

        if (sumOfDigits == num)
        {
            Console.WriteLine(num + " is a Neon number.");
        }
        else
        {
            Console.WriteLine(num + " is not a Neon number.");
        }
    }
}

internal class NestFor
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int sumOfFactorials = 0;
        int temp = num;

        while (temp > 0)
        {
            int digit = temp % 10;
            int factorial = 1;
            for (int i = 1; i <= digit; i++)
            {
                factorial *= i;
            }
            sumOfFactorials += factorial;
            temp /= 10;
        }

        if (sumOfFactorials == num)
        {
            Console.WriteLine(num + " is a special number.");
        }
        else
        {
            Console.WriteLine(num + " is not a special number.");
        }
    }
}


internal class NestFor
{
    public static void Main(string[] args)
    {
        //Console.Write("Enter the number of rows: ");
        //int rows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                //if (i == 1 || j == 1 || (i + j) == 5)
                if (i == 1 || j == 1 || i == 5 || j == 3 || (i == 3 && j == 2))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

internal class NestFor
{
    public static void Main(string[] args)
    {
        //Console.Write("Enter the number of rows: ");
        //int rows = int.Parse(Console.ReadLine());

        for (int i = 4; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                if ((i == 3) && (j == 2))
                //if (i == 1 || j == 1 ||i==5||j==3||(i==3&&j==2))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}

internal class NestFor
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}


symm right angle
internal class NestFor
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
    }
}

