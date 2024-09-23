//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//import java.util.*;

//public class Mathss
//{
//    public static void main(String[] args)
//    {
//        Scanner sc = new Scanner(System.in);

//        System.out.println("Choose the calculation:");
//        System.out.println("1. Perimeter of Square");
//        System.out.println("2. Area of Square");
//        System.out.println("3. Perimeter of Rectangle");
//        System.out.println("4. Area of Rectangle");
//        System.out.println("5. Circumference of Circle");
//        System.out.println("6. Area of Circle");
//        System.out.println("7. Area of Triangle");
//        System.out.println("8. Area of Trapezoid");
//        System.out.println("9. Surface Area of Cube");
//        System.out.println("10. Curved Surface Area of Cylinder");
//        System.out.println("11. Curved Surface Area of Cone");
//        System.out.println("12. Surface Area of Sphere");
//        System.out.println("13. Volume of Cylinder");
//        System.out.println("14. Volume of Cone");
//        System.out.println("15. Volume of Sphere");

//        int choice = sc.nextInt();

//        switch (choice)
//        {
//            case 1: // Perimeter of Square
//                System.out.print("Enter the side length of the square: ");
//                float a = sc.nextFloat();
//                System.out.println("Perimeter of the square is: " + 4 * a);
//                break;

//            case 2: // Area of Square
//                System.out.print("Enter the side length of the square: ");
//                a = sc.nextFloat();
//                System.out.println("Area of the square is: " + a * a);
//                break;

//            case 3: // Perimeter of Rectangle
//                System.out.print("Enter the length of the rectangle: ");
//                float l = sc.nextFloat();
//                System.out.print("Enter the breadth of the rectangle: ");
//                float b = sc.nextFloat();
//                System.out.println("Perimeter of the rectangle is: " + 2 * (l + b));
//                break;

//            case 4: // Area of Rectangle
//                System.out.print("Enter the length of the rectangle: ");
//                l = sc.nextFloat();
//                System.out.print("Enter the breadth of the rectangle: ");
//                b = sc.nextFloat();
//                System.out.println("Area of the rectangle is: " + l * b);
//                break;

//            case 5: // Circumference of Circle
//                System.out.print("Enter the radius of the circle: ");
//                float r = sc.nextFloat();
//                System.out.println("Circumference of the circle is: " + 2 * (float)Math.PI * r);
//                break;

//            case 6: // Area of Circle
//                System.out.print("Enter the radius of the circle: ");
//                r = sc.nextFloat();
//                System.out.println("Area of the circle is: " + (float)Math.PI * r * r);
//                break;

//            case 7: // Area of Triangle
//                System.out.print("Enter the base of the triangle: ");
//                float base = sc.nextFloat();
//                System.out.print("Enter the height of the triangle: ");
//                float height = sc.nextFloat();
//                System.out.println("Area of the triangle is: " + 0.5f * base * height);
//                break;

//            case 8: // Area of Trapezoid
//                System.out.print("Enter the first base of the trapezoid: ");
//                float base1 = sc.nextFloat();
//                System.out.print("Enter the second base of the trapezoid: ");
//                float base2 = sc.nextFloat();
//                System.out.print("Enter the height of the trapezoid: ");
//                float hTrapezoid = sc.nextFloat();
//                float aTrapezoid = ((base1 + base2) * hTrapezoid) / 2;
//                System.out.println("Area of the trapezoid is: " + aTrapezoid);
//                break;

//            case 9: // Surface Area of Cube
//                System.out.print("Enter the side length of the cube: ");
//                float sideCube = sc.nextFloat();
//                float surfaceAreaCube = 6 * sideCube * sideCube;
//                System.out.println("Surface area of the cube is: " + surfaceAreaCube);
//                break;

//            case 10: // Curved Surface Area of Cylinder
//                System.out.print("Enter the radius of the cylinder: ");
//                float rCylinder = sc.nextFloat();
//                System.out.print("Enter the height of the cylinder: ");
//                float hCylinder = sc.nextFloat();
//                float sACylinder = 2 * (float)Math.PI * rCylinder * hCylinder;
//                System.out.println("Curved surface area of the cylinder is: " + sACylinder);
//                break;

//            case 11: // Curved Surface Area of Cone
//                System.out.print("Enter the radius of the cone: ");
//                float rCone = sc.nextFloat();
//                System.out.print("Enter the slant height of the cone: ");
//                float sHeight = sc.nextFloat();
//                float sACone = (float)Math.PI * rCone * sHeight;
//                System.out.println("Curved surface area of the cone is: " + sACone);
//                break;

//            case 12: // Surface Area of Sphere
//                System.out.print("Enter the radius of the sphere: ");
//                float rSphere = sc.nextFloat();
//                float sASphere = 4 * (float)Math.PI * rSphere * rSphere;
//                System.out.println("Surface area of the sphere is: " + sASphere);
//                break;

//            case 13: // Volume of Cylinder
//                System.out.print("Enter the radius of the cylinder: ");
//                rCylinder = sc.nextFloat();
//                System.out.print("Enter the height of the cylinder: ");
//                hCylinder = sc.nextFloat();
//                float vCylinder = (float)Math.PI * rCylinder * rCylinder * hCylinder;
//                System.out.println("Volume of the cylinder is: " + vCylinder);
//                break;

//            case 14: // Volume of Cone
//                System.out.print("Enter the radius of the cone: ");
//                rCone = sc.nextFloat();
//                System.out.print("Enter the slant height of the cone: ");
//                sHeight = sc.nextFloat();
//                float hCone = (float)Math.sqrt((sHeight * sHeight) - (rCone * rCone));
//                System.out.println("Calculated height of the cone is: " + hCone);
//                float vCone = (1.0f / 3) * (float)Math.PI * rCone * rCone * hCone;
//                System.out.println("Volume of the cone is: " + vCone);
//                break;

//            case 15: // Volume of Sphere
//                System.out.print("Enter the radius of the sphere: ");
//                rSphere = sc.nextFloat();
//                float vSphere = (4.0f / 3) * (float)Math.PI * rSphere * rSphere * rSphere;
//                System.out.println("Volume of the sphere is: " + vSphere);
//                break;

//            default:
//                System.out.println("Invalid choice! Please choose a number between 1 and 15.");
//                break;
//        }
//    }
//}

////namespace BasicProgram
////{
////    internal class Rectangle
////    {
////        static void main(string[] args)
////        {
////            Console.Write("Enter the Length:");
////            int x = Convert.ToInt32(Console.ReadLine());
////            Console.Write("Enter the Breadth:");
////            int y = Convert.ToInt32(Console.ReadLine());
////            Console.WriteLine("Area:" + (x * y));
////            Console.Write("Perimeter:" + 2 * (x + y));
////        }
////    }

////}

////namespace BasicProgram
////{
////    internal class Cylinder
////    {
////        static void main(string[] args)
////        {
////            Console.Write("Enter the radius of the cylinder: ");
////            int r = Convert.ToInt32(Console.ReadLine());
////            Console.Write("Enter the height of the cylinder: ");
////            int h = Convert.ToInt32(Console.ReadLine());
////            Console.WriteLine("Curved surface area of the cylinder is: " + 2 * 3.14 * r * h);
////            Console.Write("Curved surface area of the cylinder is: " + 3.14 * r * r * h);
////        }
////    }
////}

////namespace BasicProgram
////{
////    internal class Program
////    {
////        static void main(string[] args)
////        {
////            Console.WriteLine("Enter the Length:");
////            int x = Convert.ToInt32(Console.ReadLine());
////            Console.WriteLine("Enter the Breadth:");
////            int y = Convert.ToInt32(Console.ReadLine());
////            Console.WriteLine("Area:" + (x * y));

////        }
////    }
////}

////namespace BasicProgram
////{
////internal class School
////    {
////        static void main(string[] args)
////        {
////            Console.Write("Enter Telugu Marks: ");
////            int r = Convert.ToInt32(Console.ReadLine());
////            Console.Write("Enter Hindi Marks: ");
////            int h = Convert.ToInt32(Console.ReadLine());
////            Console.Write("Enter English Marks: ");
////            int n = Convert.ToInt32(Console.ReadLine());
////            Console.Write("Enter Maths Marks: ");
////            int v = Convert.ToInt32(Console.ReadLine());
////            Console.Write("Enter Science Marks: ");
////            int k = Convert.ToInt32(Console.ReadLine());
////            int z = r + h + n + v + k;
////            Console.WriteLine("Total marks: " + z);
////            float percentage = (float)(z / 500 * 100);
////            Console.WriteLine("Percentage: " + percentage + "%");
////            string result = (percentage >= 40) ? "Pass" : "Fail";
////            Console.WriteLine(result);
////        }
////    }
////}

