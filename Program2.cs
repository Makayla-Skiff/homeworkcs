using System;

namespace CS_Intro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string food = "Eat your veggie!";

            int nub1 = 13;
            float num2 = 14.12f;
            double numb3 = 13.14;

            bool boolean = true;

            Console.WriteLine(food);
            Console.WriteLine(nub1);
            Console.WriteLine(num2);
            Console.WriteLine(numb3);
            Console.WriteLine(boolean);


            Console.ReadKey();


            string concat1 = "Eat " + "Healthy";
            string concat2 = "Be " + "Smart";

            float timne=  4.5f * 6.5f;

            const double cnum1 = 55;
            const string myname = "makayla";

            Console.WriteLine("myname is {0} {1} {2}", myname, num2, nub1);
                    



        }
    }
}
