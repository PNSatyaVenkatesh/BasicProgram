using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    enum Month{
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
    internal class Type
    {
        static void main(String[] args)
        {
            //Operators task = new Operators();
            //task.Task1();
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            Task8();
        }
        static void Task1()
        {
            String s = "5";
            int x = Convert.ToInt32(s);
            Console.WriteLine($"Integer is :{x}");
        }
        static void Task2()
        {
            int x = 7;
            double y = x;
            Console.WriteLine($"Double value: {y}");
        }
        static void Task3()
        {
            Console.Write("Enter the month : ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("January");
            }
            else if (x == 1)
            {
                Console.WriteLine("February");
            }
            else if (x == 2)
            {
                Console.WriteLine("March");
            }
            else if (x == 3)
            {
                Console.WriteLine("April");
            }
            else
            {
                Console.WriteLine("Enter Index between 0 to 3");
            }
        }
        static void Task4()
        {
            Console.Write("Enter a value : ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is Even");
            }
            else
            {
                Console.WriteLine($"{x} is Odd");
            }
        }

        static void Task5()
        {
            Console.Write("Enter a value : ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 3 == 0)
                Console.WriteLine("Fizz");           
        }

        static void Task6()
        {
            Console.Write("Enter a value : ");
            int x = Convert.ToInt32(Console.ReadLine());
            if ((x % 3 == 0)&&(x % 5==0))
                Console.WriteLine("FizzBuzz");

        }

        static void Task7()
        {
            Console.Write("Enter the length of side a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of side b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length of side c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("The values entered do not form a valid triangle.");
            }
        }
        static void Task8()
        {
            Console.Write("Enter the first number (a): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number (b): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the operation (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());
            if (operation == '+')
            {
                Console.WriteLine($"Result of {a} + {b} = {a + b}");
            }
            else if (operation == '-')
            {
                Console.WriteLine($"Result of {a} - {b} = {a - b}");
            }
            else if (operation == '*')
            {
                Console.WriteLine($"Result of {a} * {b} = {a * b}");
            }
            else if (operation == '/')
            {
                if (b != 0)
                {
                    Console.WriteLine($"Result of {a} / {b} = {a / b}");
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation entered. Please use +, -, *, or /.");
            }
        }
    }
}
