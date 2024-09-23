using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//        Console.WriteLine("First element of given Array: " + arr[0]);
//    }
//}

//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//        Console.WriteLine("Last element of given Array: " + arr[arr.Length - 1]);
//    }
//}

//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter size of Array: ");
//        int size = Convert.ToInt32(Console.ReadLine());
//        int[] arr = new int[size];
//        int sum = 0;
//        Console.WriteLine("Enter the elements: ");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = Convert.ToInt32(Console.ReadLine());
//            sum += arr[i];
//        }
//        Console.WriteLine($"Sum of elements of given array [ {string.Join(",", arr)} ] is: {sum}");
//    }
//}

//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter size of Array: ");
//        int size = Convert.ToInt32(Console.ReadLine());
//        int[] arr = new int[size];
//        int sum = 0;
//        Console.WriteLine("Enter the elements: ");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = Convert.ToInt32(Console.ReadLine());
//            sum += arr[i];
//        }
//        Console.WriteLine($"Average of elements of given array [{string.Join(",", arr)}] is: {(sum/size)}");
//    }
//}

//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter size of Array: ");
//        int size = Convert.ToInt32(Console.ReadLine());
//        int[] arr = new int[size];
//        int sum = 0; int pro = 1;
//        Console.WriteLine("Enter the elements: ");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = Convert.ToInt32(Console.ReadLine());
//            sum += arr[i];
//            pro *= arr[i];
//        }
//        Console.WriteLine($"Sum of elements of given array [{string.Join(",", arr)}] is: {sum}");
//        Console.WriteLine($"Product of elements of given array [{string.Join(",", arr)}] is: {pro}");
//    }
//}

//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = new int[2];
//        Console.Write("Enter the starting range year:");
//        arr[0] = int.Parse(Console.ReadLine());
//        Console.Write("Enter the ending range year:");
//        arr[1] = int.Parse(Console.ReadLine());
//        Console.Write($"The leap years in the range { arr[0]} and {arr[1]} are : ");
//        for (int i = arr[0]; i < arr[1]; i++)
//        {
//            if ((i % 400 == 0) || ((i % 100 != 0) && (i % 4 == 0)))
//            {
//                Console.Write(i + " ");
//            }

//        }
//    }
//}

//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        {
//            Console.Write("Enter size of Array: ");
//            int size = Convert.ToInt32(Console.ReadLine());
//            int[] arr = new int[size];
//            Console.WriteLine("Enter the elements: ");
//            for (int i = 0; i < size; i++)
//            {
//                arr[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            Console.Write("Enter number to search: ");
//            int num = Convert.ToInt32(Console.ReadLine());
//            bool search = false;
//            foreach (int i in arr)
//            {
//                if (i == num)
//                {
//                    search = true;
//                    break;
//                }
//            }
//            Console.WriteLine(search ? $"Array contains {num} " : $"Array doesn't contain {num}");
//        }
//    }
//}

//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter the size of array:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Enter the elements :");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        Console.Write("Enter the element to search: ");
//        int num = int.Parse(Console.ReadLine());
//        int flag = 0;
//        for (int i = 0; i < size; i++)
//        {
//            if (arr[i] == num)
//            {
//                flag = 1;
//               Console.WriteLine($"Element {num} found at index  {(i + 1)}");
//                break;
//            }           
//        }
//        if(flag==0) Console.WriteLine($"Element {num} is not found. ");
//    }
//}

//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter the size of an array:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Enter the elements :");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int even = 0;
//        int odd = 0;
//        for (int i = 0; i < size; i++)
//        {
//            if (arr[i] % 2 == 0)
//            {
//                even++;
//            }
//            else { odd++; }
//        }
//        Console.WriteLine("No of even numbers in array are: " + even);
//        Console.WriteLine("No of odd numbers in array are: " + odd);

//    }
//}


//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter the size of an array:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Enter the elements :");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        int pri = 0;

//        for (int i = 0; i < size; i++)
//        {
//            if (prime(arr[i]))
//            {
//                pri++;
//            }

//        }
//        Console.WriteLine("Number of prime numbers in the given array: " + pri);
//    }
//    static bool prime(int j)
//    {
//        for (int i = 2; i < j; i++)
//        {
//            if (j % i == 0)
//                return false;
//        }
//        return true;


//    }
//}

//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter the size of array:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Enter the elements :");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        Console.Write("Enter the index to be inserted at :");
//        int index = int.Parse(Console.ReadLine());
//        Console.Write("Enter the element to be inserted :");
//        int x = int.Parse(Console.ReadLine());
//        arr[index] = x;
//        Console.WriteLine("The element " + x + " is inserted successfully at index " + index);
//        Console.WriteLine($"Array after insertion: [{string.Join(",", arr)}]");
//    }
//}

//internal class Arrays
//{
//    public static void Main(string[] args)
//    {
//        Console.Write("Enter the size of array:");
//        int size = int.Parse(Console.ReadLine());
//        int[] arr = new int[size];
//        Console.WriteLine("Enter the elements :");
//        for (int i = 0; i < size; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//        }
//        Console.Write("Enter the index to be inserted at :");
//        int index = int.Parse(Console.ReadLine());
//        Console.Write("Enter the element to be inserted :");
//        int x = int.Parse(Console.ReadLine());
//        arr[index] = x;
//        Console.WriteLine("The element " + x + " is inserted successfully at index " + index);
//        Console.WriteLine($"Array after insertion: [{string.Join(",", arr)}]");
//    }
//}