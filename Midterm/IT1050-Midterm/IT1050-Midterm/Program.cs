using System;

namespace IT1050_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Question 1: (had to copy this code to separate file)
            bool keepLooping = true;
            while (keepLooping = true)
            {
                Console.Write("*");
                Console.WriteLine();
            }
            */

            // Question 2:
            int m = 2;

            while (m <= 128)
            {
                Console.WriteLine("[{0}]", m); // Console.WriteLine("[{0}]",);
                m *= 2;
            }

            // Question 3:
            for (int z = 49; z > 0; z--)
            {
                if (z != 1)
                {
                    Console.Write("{0}, ", z);
                }
                else if (z == 1)
                {
                    Console.Write("1");
                    Console.WriteLine();
                }
            }

            // Question 4:
            int c = 1;

            while (c <= 21)
            {
                Console.Write("{0}   ", c);
                c += 2;
            }
            Console.WriteLine("");

            // Question 5:
            // The do ... while iteration statement is similar to the while statement. In the while, the app tests the loop-continuation condition at the beginning of the loop, before executing the loop's body. If the condition is false, the body never executes. The do ... while statement tests the loop-continuation condition after executing the loop's body; therefore, the body always executes at least once. When a do ... while statement terminates, execution continues with the next statement in sequence.
            int n = 8;
            int i = 10;
            while (i < n);
            {
                Console.Write("*");
                i++;
            }

            // Question 6:
            bool icyRain = false;
            bool tornadoWarning = false;

            if (icyRain == false && tornadoWarning == false)
            {
                Console.WriteLine("Let's go outside!");
            }

            if ((icyRain == false) || (tornadoWarning == false))
            {
                Console.WriteLine("Let's go outside!");
            }
        }
    }
}
