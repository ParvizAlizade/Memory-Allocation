using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Eded daxil edin");
            int eded = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Create(eded));
        }


        static int Create(int eded)
        {
            int reqem = eded;
            int mertebe = 1;
            while (eded > 10)
            {
                eded = (eded - (eded % 10)) / 10;
                mertebe++;
            }
            int ust = 1;
            for (int i = 1; i <= mertebe; i++)
            {
                ust *= 10;
            }
            int netice = 3 * ust + reqem;
            return netice;
        }
    }
}
