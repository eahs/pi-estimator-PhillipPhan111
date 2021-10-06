using System;

namespace PiEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            
            double acc = 0;
            Console.WriteLine("Pi Estimator");
            Console.WriteLine("================================================");

            n = GetNumber("Enter number of iterations (n): ");

            double pi = EstimatePi(n);
            double diff = Math.Abs(pi - Math.PI);

            Console.WriteLine();
            Console.WriteLine($"Pi (estimate): {pi}, Pi (system): {Math.PI}, Difference: {diff}");
        }

        static double EstimatePi(long n)
        {
            Random rand = new Random(System.Environment.TickCount);
            double totalToss = 0;
            double acc = 0;
            
            while (totalToss < n)
            {
                totalToss++;
                double xpos = rand.NextDouble();
                double ypos = rand.NextDouble();
                if (Math.Sqrt((xpos * xpos) + (ypos * ypos)) <= 1)
                {
                    acc++;
                }
                
            }

            double pie = 4 * acc / totalToss;
            return pie;
        }

        static long GetNumber(string prompt)
        {
            long output;

            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (Int64.TryParse(input, out output))
                {
                    return output;
                }
            }
        }
    }
}