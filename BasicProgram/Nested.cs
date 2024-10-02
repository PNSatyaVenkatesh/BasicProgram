using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Nested
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator Menu:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice (1 to 4): ");
            int choice = int.Parse(Console.ReadLine());

            if ((choice == 1) || (choice == 2) || (choice == 3) || (choice == 4))
            {
                Console.Write("Enter first number (a): ");
                float a = float.Parse(Console.ReadLine());

                Console.Write("Enter second number (b): ");
                float b = float.Parse(Console.ReadLine());
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result of {a} + {b} = {a + b}");
                    break;

                case 2:
                    Console.WriteLine($"Result of {a} - {b} = {a - b}");
                    break;

                case 3:
                    Console.WriteLine($"Result of {a} * {b} = {a * b}");
                    break;

                case 4:
                    if (b != 0)
                    {
                        Console.WriteLine($"Result of {a} / {b} = {a / b}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid operation (1-4).");
                    break;
            }
        }
    }
}

namespace BasicProgram
{
    internal class Nested
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator using Operators");
            Console.WriteLine("Select the Operators:");
            Console.WriteLine("+ , - , * , / ");

            Console.Write("Enter your choice: ");
            String choice = Console.ReadLine();
            Console.Write("Enter first number (a): ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Enter second number (b): ");
            float b = float.Parse(Console.ReadLine());
            switch (choice)
            {
                case "+":
                    Console.WriteLine($"Result of {a} + {b} = {a + b}");
                    break;

                case "-":
                    Console.WriteLine($"Result of {a} - {b} = {a - b}");
                    break;

                case "*":
                    Console.WriteLine($"Result of {a} * {b} = {a * b}");
                    break;

                case "/":
                    if (b != 0)
                    {
                        Console.WriteLine($"Result of {a} / {b} = {a / b}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid operation.");
                    break;
            }
        }
    }
}

namespace BasicProgram
{
    internal class Nested
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator using Operators");
            Console.WriteLine("Select the Operators:");
            Console.WriteLine("Addition\nSubtraction\nMultiplication\nDivison ");

            Console.Write("Enter your choice: ");
            String choice = Console.ReadLine();
            Console.Write("Enter first number (a): ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Enter second number (b): ");
            float b = float.Parse(Console.ReadLine());
            switch (choice)
            {
                case "Addition":
                    Console.WriteLine($"Result of {a} + {b} = {a + b}");
                    break;

                case "Subtraction":
                    Console.WriteLine($"Result of {a} - {b} = {a - b}");
                    break;

                case "Multiplication":
                    Console.WriteLine($"Result of {a} * {b} = {a * b}");
                    break;

                case "Divison":
                    if (b != 0)
                    {
                        Console.WriteLine($"Result of {a} / {b} = {a / b}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid operation.");
                    break;
            }
        }
    }
}

namespace BasicProgram
{
    internal class Nested
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator using Operators");
            Console.WriteLine("Select the Operators:");
            Console.WriteLine("+ , - , * , / ");

            Console.Write("Enter your choice: ");
            String choice = Console.ReadLine();
            Console.Write("Enter first number (a): ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("Enter second number (b): ");
            float b = float.Parse(Console.ReadLine());
            switch (choice)
            {
                case "+":
                    Console.WriteLine($"Result of {a} + {b} = {a + b}");
                    break;

                case "-":
                    Console.WriteLine($"Result of {a} - {b} = {a - b}");
                    break;

                case "*":
                    Console.WriteLine($"Result of {a} * {b} = {a * b}");
                    break;

                case "/":
                    if (b != 0)
                    {
                        Console.WriteLine($"Result of {a} / {b} = {a / b}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid operation (1-4).");
                    break;
            }
        }
    }
}


namespace BasicProgram
{
    internal class Nested
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter suitable option for following \n1.Veg \n2.Non-Veg");
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    {
                        Console.WriteLine("Enter suitable option for following \n1.Idly \n2.Paneer \n3.Gobi");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the quantity of Idly");
                                int quant = int.Parse(Console.ReadLine());
                                Console.WriteLine("The Total Price for Idly is : " + (quant * 25));
                                break;

                            case 2:
                                Console.WriteLine("Enter the quantity of Paneer");
                                int quant1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("The Total Price for Paneer is : " + (quant1 * 50));
                                break;

                            case 3:
                                Console.WriteLine("Enter the quantity of Gobi");
                                int quant2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("The Total Price for Gobi is : " + (quant2 * 75));
                                break;

                            default:
                                Console.WriteLine("Enter the Valid Option");
                                break;

                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter suitable option for following \n1.Mutton Curry \n2.Prawns \n3.Chicken Biriyani");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter the quantity of Mutton Curry");
                                int quant = int.Parse(Console.ReadLine());
                                Console.WriteLine("The Total Price for Mutton Curry is : " + (quant * 125));
                                break;

                            case 2:
                                Console.WriteLine("Enter the quantity of Prawns");
                                int quant1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("The Total Price for Prawns is : " + (quant1 * 150));
                                break;

                            case 3:
                                Console.WriteLine("Enter the quantity of Chicken Biriyani");
                                int quant2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("The Total Price for Chicken Biriyani is : " + (quant2 * 275));
                                break;

                            default:
                                Console.WriteLine("Enter the Valid Option");
                                break;

                        }
                    }
                    break;
                default:
                    Console.WriteLine("Enter the Valid Option");
                    break;
            }

        }
    }
}


internal class Nested
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the year you want to check: \n1.First Year ");
        int opt = int.Parse(Console.ReadLine());
        switch (opt)
        {
            case 1:
                {
                    Console.WriteLine("Enter the semester you want to check: \n1.First Semester \n2.Second Semester");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("The subjects available in first semester are : \n1.Maths \n2.Chemistry \n3.BEEE \n4.C language \n5.IEV");
                            break;

                        case 2:
                            Console.WriteLine("The subjects available in second semester are : \n1.Physics \n2.Biology \n3.English \n4.Python \n5.AIML");
                            break;


                        default:
                            Console.WriteLine("Enter the Valid Option");
                            break;

                    }
                }
                break;

            default:
                Console.WriteLine("Enter the Valid Option");
                break;
        }

    }
}

