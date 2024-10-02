using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Sort
{
    public static void Main(string[] args)
    {
        int[] num = { 80, 27, 43, 78, 57 };
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < num.Length; j++)
            {
                if (num[i] < num[j])
                {
                    int temp = num[i]; num[i] = num[j]; num[j] = temp;
                }
            }
        }
        Console.WriteLine($"Ascending order of given array :");
        foreach (int x in num)
        {
            Console.Write(x + " ");
        }
    }
}


internal class Sort
{
    public static void Main(string[] args)
    {
        int[] num = { 80, 27, 43, 78, 57 };
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < num.Length; j++)
            {
                if (num[i] > num[j])
                {
                    int temp = num[i]; num[i] = num[j]; num[j] = temp;
                }
            }
        }
        Console.WriteLine($"Descending order of given array :");
        foreach (int x in num)
        {
            Console.Write(x + " ");
        }
    }
}

internal class Sort
{
    static void Main(string[] args)
    {
        int[] num = { 80, 27, 43, 78, 57 };
        int min = num[0];
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
            }
        }
        Console.WriteLine("The minimum value is: " + min);
    }
}

internal class Sort
{
    static void Main(string[] args)
    {
        int[] num = { 209, 78, 56, 2, 39, 4567, 67, 98 };
        int max = num[0];
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
            }
        }
        Console.WriteLine("The maximum value is: " + max);
    }
}

internal class Sort
{
    public static void Main(string[] args)
    {
        int[] num = { 80, 27, 43, 78, 57 };
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < num.Length; j++)
            {
                if (num[i] < num[j])
                {
                    int temp = num[i]; num[i] = num[j]; num[j] = temp;
                }
            }
        }
        int small = num[0];
        for (int i = 0; i <= 4; i++)
        {
            if (num[i] != small)
            {
                Console.WriteLine("Second Minimum number in array :" + num[i]);
                break;
            }

        }

    }
}

internal class Sort
{
    public static void Main(string[] args)
    {
        int[] num = { 80, 27, 43, 78, 57 };
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < num.Length; j++)
            {
                if (num[i] > num[j])
                {
                    int temp = num[i]; num[i] = num[j]; num[j] = temp;
                }
            }
        }
        int large = num[0];
        for (int i = 0; i <= 4; i++)
        {
            if (num[i] != large)
            {
                Console.WriteLine("Second Maximum number in array :" + num[i]);
                break;
            }

        }

    }
}

internal class Sort
{
    public static void Main(String[] args)
    {

        int[] arr = { 10, 72, 55, 10, 60, 33, 55 };
        Console.WriteLine("Duplicates numbers the array :");
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {

                if (arr[i] == arr[j])
                    Console.Write(arr[j] + "  ");
            }
        }
    }
}
