using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Task1(int a, int b)
        {
            int x1 = a;
            int x2 = a;

            for (int step = 1; step <= b - 1; step++)
            {
                x2 *= x1;
            }

            return x2;
        }

        static string Task2(int a)
        {
            int remainder;
            string all = "";

            for (int i = 1; i <= 1000; i++)
            {
                remainder = i % a;
                if (remainder == 0)
                {
                    all += $"{i}, ";
                }
            }

            return all;
        }

        static int Task3(int a)
        {
            int n = 0;

            while (n * n < a)
            {
                ++n;
            }
            --n;

            return n;
        }

        static int Task4(int a)
        {
            int n = 1;
            int divisor = 0;

            while (n != a)
            {
                if (a % n == 0)
                {
                    divisor = n;
                }
                ++n;
            }
            --n;

            return divisor;
        }

        static int Task5(int a, int b)
        {
            int sum = 0;

            if (b < a)
            {
                int temp;
                temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        static int Task6(int a)
        {
            int fibonacci1 = 1;
            int fibonacci2 = 1;
            int fibonacci3 = 0;

            for (int i = 0; i <= a - 3; i++)
            {
                fibonacci3 = fibonacci1 + fibonacci2;
                fibonacci1 = fibonacci2;
                fibonacci2 = fibonacci3;
            }

            return fibonacci3;
        }

        static int Task7(int a, int b)
        {
            int remainder;
            do
            {
                remainder = a % b;
                a = b;
                if (remainder != 0)
                {
                    b = remainder;
                }
            } while (remainder != 0);

            return b;
        }

        static int Task10(int n)
        {
            int reverse = 0;
            int remainder;

            while (n != 0)
            {
                remainder = n % 10;
                reverse = reverse * 10 + remainder;
                n /= 10;
            }
            return reverse;
        }

        static double Task13(int a)
        {
            double sum = 0;
            double i = 1.0;

            for (i = 50; i >= 1; i--)
            {
                sum = (Math.Sqrt(i + sum));
            }

            return sum;
        }

        static int Task14(double a)
        {
            int n = 1;
            double sum = 0;
            do
            {
                sum += 1 / n;
                n++;
            } while (sum > a);

            return n;
        }

        static void Main(string[] args)
        {
            int all = Task10(2241956);
            Console.WriteLine(all);
        }
    }
}

