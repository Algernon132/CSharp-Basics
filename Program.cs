using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlesBruscato
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800f;
            float mass = 14.6f;
            double distance = 129.763001d;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const string greeting = "Hello";
            string name = "Karen";

            if(sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }
            Console.WriteLine();

            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.");
            }
            Console.WriteLine();

            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }
            Console.WriteLine();

            float force = mass * acceleration;
            Console.WriteLine("force = {0}", force);
            Console.WriteLine();

            Console.WriteLine(distance.ToString("N4") + " is the distance.");    //ToString allows me to choose specificity. It isn't necessary here.
            Console.WriteLine();

            if(lost && expensive)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            }else if (lost & !expensive)
            {
                Console.WriteLine("Here is a coupon for 10% off.");
            }
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.");
                    break;

                case 2:
                    Console.WriteLine("You chose 2.");
                    break;

                case 3:
                    Console.WriteLine("You chose 3.");
                    break;

                default:
                    Console.WriteLine("You made an unkown choice.");
                    break;
            }

            Console.WriteLine("{0} is an integral", integral);
            Console.WriteLine();

            for(int i = 5; i <= 10; i++)
            {
                Console.WriteLine("i= "+i);
            }
            Console.WriteLine();

            int age = 0;
            while(age < 6)
            {
                Console.WriteLine("age = " + age++);
            }
            Console.WriteLine();

            Console.WriteLine(greeting + " " + name);

            Console.ReadLine(); //wait for user input to close console
        }
    }
}
