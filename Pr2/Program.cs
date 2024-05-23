using System;

namespace Pr2
{
    class Program
    {
        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        static void Task1()
        {
            Console.WriteLine("Task 1");

            int n = 7;
            int a, b, c;
            int lowerBound = 1;
            int upperBound = 10 + n;

            Console.Write("Enter first number: ");
            a = int.Parse(Console.ReadLine()!);

            Console.Write("Enter second number: ");
            b = int.Parse(Console.ReadLine()!);

            Console.Write("Enter third number: ");
            c = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Numbers belonging to the interval [{0},{1}]:", lowerBound, upperBound);
            if (a >= lowerBound && a <= upperBound) Console.WriteLine(a);
            if (b >= lowerBound && b <= upperBound) Console.WriteLine(b);
            if (c >= lowerBound && c <= upperBound) Console.WriteLine(c);
        }

        static void Task2()
        {
            Console.WriteLine("Task 2");

            Console.Write("Enter first side of triangle: ");
            double a = double.Parse(Console.ReadLine()!);

            Console.Write("Enter second side of triangle: ");
            double b = double.Parse(Console.ReadLine()!);

            Console.Write("Enter third side of triangle: ");
            double c = double.Parse(Console.ReadLine()!);

            if (IsValidTriangle(a, b, c))
            {
                double perimeter = a + b + c;
                double s = perimeter / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Triagle type: {GetTriangleType(a, b, c)}");
            }
            else
            {
                Console.WriteLine("Triangle with such sides does not exist");
            }

            static bool IsValidTriangle(double a, double b, double c)
            {
                return a + b > c && a + c > b && b + c > a;
            }

            static string GetTriangleType(double a, double b, double c)
            {
                if (a == b && b == c)
                    return "Equilateral";
                else if (a == b || a == c || b == c)
                    return "Isosceles";
                else
                    return "Versatile";
            }
        }

        static void Task3()
        {
            Console.WriteLine("Task 3");

            int n = 3; 
            int[] X = new int[10 + n];
            Random rand = new();

            Console.WriteLine("Array X:");
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rand.Next(-100, 101); 
                Console.Write(X[i] + " ");
            }
            Console.WriteLine();

            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (int num in X)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
        }

        static void Task4()
        {
            Console.WriteLine("Task 4");

            int n = 3; 
            int[] X = new int[10 + n];
            Random rand = new();

            Console.WriteLine("Масив X:");
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = rand.Next(-100, 101); 
                Console.Write(X[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Enter a number M: ");
            int M = int.Parse(Console.ReadLine()!);

            int[] Y = X.Where(num => Math.Abs(num) > Math.Abs(M)).ToArray();

            Console.WriteLine($"Number M: {M}");
            Console.WriteLine("New array Y:");
            foreach (int num in Y)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}