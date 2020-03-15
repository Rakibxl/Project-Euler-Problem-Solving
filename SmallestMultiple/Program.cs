using System;

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the range");
            int range = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is " + smallestMult(range));
            Console.ReadKey();
        }

       public static int lcm(int a, int b)
        {
            return (a * b) / gcd(a, b);
        }


        public static int gcd(int a, int b)
        {
            if(b==0)
            {
                return a;
            }

            return gcd(b, a % b);
        }

        public static int smallestMult( int n)
        {
            int maxLCM = 1;

            //Getting the lcm  in the range 

            for(int i=2; i<=n; i++ )
            {
                maxLCM = lcm(maxLCM, i);
            }
            return maxLCM;
        }


    }
}
