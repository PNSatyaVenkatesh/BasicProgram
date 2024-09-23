using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Operator
    {
        static void main(String[] args)
        {
            //Operators task = new Operators();
            //task.Task10();
            Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
        }
        static void Task1()
        {
            Console.Write("Enter the 1st number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number: ");
            int y =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividend:" + x);
            Console.WriteLine("Divisor:" + y);
            Console.WriteLine("Quotient:" + (x / y));
            Console.WriteLine("Reminder:" + (x % y));
        }
        static void Task2()
        {
            Console.Write("Enter the 1st number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number: ");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine("Dividend:" + x);
            Console.WriteLine("Divisor:" + y );
            Console.WriteLine("Quotient:" + (x / y));
            Console.WriteLine("Reminder:" + (x % y));
        }
        static void Task3()
        {
            Console.Write("Enter the 1st number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum:" + (x+y));
            Console.WriteLine("Difference:" + (x-y));
            Console.WriteLine("Product:" + (x * y));
            Console.WriteLine("Division:" + (x / y));
            Console.WriteLine("Modulus:" + (x % y));
        }
        static void Task4()
        {
            Console.Write("Enter a value : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b value: ");
            int y = Convert.ToInt32(Console.ReadLine());
            x += y;
            y *= 50;
            x /= y;         
            Console.WriteLine("a:" + x);
            Console.WriteLine("b:" + y);
        }

        static void Task5()
        {
            Console.Write("Enter the 1st number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x==y)?$"{x} & {y} are same:" : $"{x} & {y} are not same");
        }

        static void Task6()
        {
            Console.Write("Enter the number : ");
            int x = Convert.ToInt32(Console.ReadLine());          
            Console.WriteLine((x == 5) ? "You entered number 5" : "Number you entered is not 5");
        }

        static void Task7()
        {
            Console.Write("Enter the number of dollar(s): ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"${x} Equals to: Rs.{x * 83.97}");
        }

        static void Task8()
        {
            Console.Write("Enter the number of Indian Rupee(s): ");
            float x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Rs.{x} Equals to: ${x / 83.97}");
        }

        static void Task9()
        {
            Console.Write("Enter number of meter(s) : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{x} m Equals to : {x/1000.0F} Km");
        }

        static void Task10()
        {
            Console.Write("Enter Price : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Total Price with 12% G.S.T is: {(x * y) + (x * y * 0.12)}");
        }

        static void Task11()
        {
            Console.Write("Enter Price : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            int y = Convert.ToInt32(Console.ReadLine());
            double cost = (((x * y) > 1000) ? ((x * y) - (x * y * (0.05))) : (x * y));
            Console.WriteLine(((x*y)>1000)? "You got 5 % discount" : $"If you buy Rs. {1001-(x*y)} more, you will get 5% discount on your bill");
            Console.WriteLine($"Your Final Bill Price:{cost}");
        }

        static void Task12()
        {
            Console.Write("Enter number of Radian(s) : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The degrees for {x} Radian(s) are :{x* 57.296}");
        }
    }
}
