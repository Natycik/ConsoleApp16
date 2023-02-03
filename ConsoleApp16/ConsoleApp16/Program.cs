using System;

namespace ConsoleApp1

{
    class primer
    {

        public int vich(int a, int b)
        {
            Console.WriteLine("Сумма целых чисел  " + (a + b));
            return a + b;

        }

        public double vich(double a, double b)
        {
            Console.WriteLine("Сумма вещественных чисел  " + (a + b));
            return a + b;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            primer test = new primer();
            int a = 5; int b = 6;
            test.vich(a, b);
            double x = 0.5;
            double y = 0.6;
            x = 0.5;
            y = 0.6;
            if (x == 0) {; }
            test.vich(x, y);

        }
    }
}
