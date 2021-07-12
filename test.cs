using System;

namespace test1
{
    class Program1
    {
        static void Main(string[] args)
        {   int modeOfStudy;
            System.Console.WriteLine("Are you a PartTime or FullTime Student? Reply 1 if PartTime and 2 if FullTime");
            modeOfStudy = Convert.ToInt32(Console.ReadLine());
            if (modeOfStudy == 2) {
            System.Console.WriteLine("What course are you studying?");
            string course = Console.ReadLine();
            System.Console.WriteLine(course + " is a good course");
            }


            else if (modeOfStudy == 1)
            {
                System.Console.WriteLine("How many unit are you taking!?");
                int unit = Convert.ToInt32(Console.ReadLine());
                if (unit > 6)
                System.Console.WriteLine("Too much unit for a PartTime Sudent");
                else
                System.Console.WriteLine("Proceed to the screen!");
            }
        }
    }
}
