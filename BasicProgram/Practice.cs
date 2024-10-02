using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter 1st number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number:");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine(x + " is greater than " + y);
            }
            else
            {
                Console.WriteLine(y + " is greater than " + x);
            }
        }
    }
}


namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter 1st number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number:");
            int z = Convert.ToInt32(Console.ReadLine());
            if ((x > y) && (x > z))
            {
                Console.WriteLine($"{x} is greater than {y} & {z}");
            }
            else if ((y > x) && (y > z))
            {
                Console.WriteLine($"{y} is greater than {x} & {z}");
            }
            else
            {
                Console.WriteLine($"{z} is greater than {x} & {y}");
            }
        }
    }
}

namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the year:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && ((year % 400 == 0) || (year % 100 != 0))))
            {
                Console.WriteLine(year + " is leap year");
            }
            else
            {
                Console.WriteLine(year + " is not leap year");
            }
        }
    }
}

namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(x + " is Positive");
            }
            else if (x < 0)
            {
                Console.WriteLine(x + " is Negative");
            }
            else
            {
                Console.WriteLine(x + " Neither Positive nor Negative");
            }
        }
    }
}

namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m > 0)
            {
                Console.WriteLine("n = 1");
            }
            else if (m == 0)
            {
                Console.WriteLine("n = 0");
            }
            else
            {
                Console.WriteLine("n = -1");
            }
        }
    }
}

namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter x value:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y value:");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("Quadrant 1");
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine("Quadrant 2");
            }
            else if ((x < 0) && (y < 0))
            {
                Console.WriteLine("Quadrant 3");
            }
            else if ((x > 0) && (y < 0))
            {
                Console.WriteLine("Quadrant 4");
            }
            else
            {
                Console.WriteLine("Origin");
            }
        }
    }
}

namespace BasicProgram
{
    internal class Practice
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Enter number of units consumed  : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n < 100)
            {
                Console.WriteLine("Free of cost");

            }
            else if (n >= 100 && n <= 500)
            {
                Console.WriteLine("Electricty bill charge : " + (n * 5));

            }

            else if (n > 500)
            {
                Console.WriteLine("Electricty bill charge : " + (n * 7.25));

            }
            else
            {
                Console.WriteLine("Enter Valid number of units used");
            }

        }
    }
}


11 / 9 / 24

namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the temperature(C): ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n <= 10)
            {
                Console.WriteLine("Very cool");
            }
            else if (n > 10 && n <= 20)
            {
                Console.WriteLine("Cool");
            }

            else if (n > 20 && n <= 30)
            {
                Console.WriteLine("Normal");
            }
            else if (n > 30 && n <= 40)
            {
                Console.WriteLine("Hot");
            }
            else if (n > 40)
            {
                Console.WriteLine("Very hot");
            }
            else
            {
                Console.WriteLine("Don't provide Negative temperature values");
            }

        }
    }
}

namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the User Name: ");
            String n = Console.ReadLine();
            Console.Write("Enter the Email ID: ");
            String m = Console.ReadLine();
            if (n == "Satya")
            {
                if (m == "Satya@gmail.com")
                {
                    Console.WriteLine("Successfully Logged in");
                }
                else
                {
                    Console.WriteLine("Enter correct Mail Id associated with User Satya");
                }
            }
            else
            {
                Console.WriteLine("Enter Valid User Name.");
            }

        }
    }
}


namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the marks secured in Aptitude: ");
            int apt = Convert.ToInt32(Console.ReadLine());
            if (apt > 85)
            {
                Console.WriteLine("You are qualified in Aptitude Round");
                Console.Write("Enter the marks secured in GD Round: ");
                int gd = Convert.ToInt32(Console.ReadLine());
                if (gd > 90)
                {
                    Console.WriteLine("You are qualified in GD Round");
                    Console.Write("Enter the marks secured in Technical Round: ");
                    int tech = Convert.ToInt32(Console.ReadLine());
                    if (tech >= 80)
                    {
                        Console.WriteLine("You are qualified in Technical Round");
                        Console.Write("Enter the marks secured in HR Round: ");
                        int hr = Convert.ToInt32(Console.ReadLine());
                        if (hr >= 90)
                        {
                            int sum = apt * gd * tech * hr;
                            sum = sum / 4;
                            if (sum >= 95)
                            {
                                Console.Write("Congrats you are selected with Salary of Rs.25000");
                            }
                            else if (sum >= 80 && sum < 95)
                            {
                                Console.Write("Congrats you are selected with Salary of Rs.20000");
                            }
                            else if (sum < 80)
                            {
                                Console.Write("Congrats you are selected with Salary of Rs.15000");
                            }
                            else
                            {
                                Console.Write("Will get back to you when we require you");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry you are not qualified in HR round");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry you are not qualified in Technical round");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry you are not qualified in GD round");
                }
            }
            else
            {
                Console.WriteLine("Sorry you are not qualified in Aptitude round");
            }
        }
    }
}

namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter length of Rectangle: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth of Rectangle: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (l == b)
            {
                Console.WriteLine($" {l}L & {b}B of this rectangle forms a Square. ");
            }
            else
            {
                Console.WriteLine($" {l}L & {b}B of this rectangle doesn't form a Square. ");
            }

        }
    }
}

namespace BasicProgram
{
    internal class Practice
    {
        public static void main(string[] args)
        {
            Console.Write("Enter name of Product: ");
            String name = Console.ReadLine();
            Console.Write("Enter Price of the Product: ");
            float price = float.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine($"Product Name:{name}");
            Console.WriteLine($"Product Price:{price}");
            Console.WriteLine($"Quantity:{quant}");
            ////Console.WriteLine
            //if (l == b)
            //{
            //    Console.WriteLine($" {l}L & {b}B of this rectangle forms a Square. ");
            //}
            //else
            //{
            //    Console.WriteLine($" {l}L & {b}B of this rectangle doesn't form a Square. ");
            //}

        }
    }
}


namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter the Item Name :");
            String name = Console.ReadLine();
            Console.Write("Enter the Unit Price:");
            int price = int.Parse(Console.ReadLine());
            Console.Write("Enter the Quantity:");
            int quant = int.Parse(Console.ReadLine());
            int total = price * quant;
            Console.WriteLine("Item Name   :" + name);
            Console.WriteLine("1 Unit Price:" + price);
            Console.WriteLine("Quantity    :" + quant);
            Console.WriteLine("Total  Price:" + total);
            if (total > 1000)
            {
                Console.WriteLine("Discount Applied");
                Console.WriteLine("Final Price to be Paid : " + (total - (0.10) * total));

            }
            else
            {
                Console.WriteLine("No Discount Applied");
                Console.WriteLine("Final Price to be Paid : " + total);
            }
        }
    }
}

namespace BasicProgram
{
    internal class Practice
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter your Employee Id: ");
            String id = Console.ReadLine();
            Console.Write("Enter your Employee Name: ");
            String name = Console.ReadLine();
            Console.Write("Enter your Experience: ");
            int exp = int.Parse(Console.ReadLine());
            Console.Write("Enter your salary: ");
            int salary = int.Parse(Console.ReadLine());

            if (exp >= 5)
            {
                Console.WriteLine("Bonus Availed on Salary");
                Console.WriteLine("Updated Salary is :" + (salary + (0.05) * salary));
            }
            else
            {
                Console.WriteLine("Bonus Not Availed on Salary");
            }
        }
    }
}

internal class Practice
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the total classes held: ");
        float total = float.Parse(Console.ReadLine());
        Console.Write("Enter the number of classes attended: ");
        int attended = int.Parse(Console.ReadLine());
        float percentage = (attended / total) * 100;
        Console.WriteLine(percentage >= 75 ? "Eligible for Exam" : "Not Eligible for Exam");
    }
}


