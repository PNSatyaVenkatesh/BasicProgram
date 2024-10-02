using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

internal class Pattern
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}

internal class Pattern
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}

internal class Pattern
{
    public static void Main(string[] args)
    {
        int c = 1;
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.Write(c++);
            }
            Console.WriteLine();
        }
    }
}

internal class Pattern
{
    public static void Main(string[] args)
    {
        for (int i = 7; i <= 9; i++)
        {
            for (int j = 4; j <= 6; j++)
            {
                for (int k = 1; k <= 3; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
                Console.Write(j);
            }
            Console.WriteLine();
            Console.WriteLine(i);
        }
    }
}

internal class Pattern
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                if (((i == 2) && (j == 2)) || ((i == 4) && (j == 2)) || ((i == 3) && (j == 3)))
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("B ");

                }
            }
            Console.WriteLine();
        }
    }
}

internal class Pattern
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                if (((i == 2) && (j == 2)) || ((i == 4) && (j == 2)))
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write("8 ");

                }
            }
            Console.WriteLine();
        }
    }
}

internal class Pattern
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                if (i == 1 || j == 1 || i == 4 || j == 4)
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

internal class Pattern
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

internal class Pattern
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

internal class Pattern
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    }
}

internal class Pattern
{
    public static void Main(string[] args)
    {
        for (int i = 3; i <= 5; i++)
        {
            for (int j = 3; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}

internal class Pattern
{
    public static void main(string[] args)
    {
        int c = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(c++);
            }
            Console.WriteLine();
        }
    }
}


namespace BasicProgram
{
    internal class Patterns
    {
        static void Main(String[] args)
        {




            pattern0(4);
            Console.WriteLine("*");
            pattern1(4);
            Console.WriteLine("*");
            pattern2(4);
            Console.WriteLine("*");
            pattern3(4);
            Console.WriteLine("*");
            pattern4(4);
            Console.WriteLine("*");
            pattern5(4);
            Console.WriteLine("*");
            pattern6(4);
            Console.WriteLine("*");
            pattern7(4);
            Console.WriteLine("*");
            pattern8(4);
            Console.WriteLine("*");

            pattern9(4);
            Console.WriteLine("*");
            pattern10(4);





        }

        static void pattern0(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
            }

        }

        static void pattern1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }

        }
        static void pattern2(int n)
        {
            int c = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(c + " ");
                    c = c + 1;
                }
                Console.WriteLine("");
            }

        }
        static void pattern3(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == n - 1 || j == n - 1)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
        static void pattern4(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == n - 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }


        }
        static void pattern5(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == n - 1 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }



        }
        static void pattern6(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }


        }
        static void pattern7(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }


        }

        static void pattern8(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("# ");
                    }
                }
                Console.WriteLine("");
            }


        }
        static void pattern9(int n)
        {
            int c = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(c + " ");
                }
                c = c + 1;
                Console.WriteLine("");
            }

        }
        static void pattern10(int n)
        {
            int c = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(c + " ");
                    c = c + 1;
                }
                Console.WriteLine("");
            }
        }
    }
}