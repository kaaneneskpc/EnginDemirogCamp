using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            string categoryTag = "Category";
            int numberOfStudent = 32000;
            double bankRate = 1.45;
            bool isLogin = true;
            double dollarOld = 7.35;
            double dollarNew = 7.45;

            //Console.WriteLine(categoryTag);

            //İf - Else

            if (dollarOld>dollarNew)
            {
                Console.WriteLine("Down Button");
            }
            else if(dollarOld<dollarNew)
            {
                Console.WriteLine("Up Down");
            }
            else
            {
                Console.WriteLine("Not Changed");
            }

            if (isLogin == true)
            {
                Console.WriteLine("User Settings Button");
            }
            else
            {
                Console.WriteLine("Login Button");
            }

            Console.WriteLine("**********---------------------------------------***************");

            //Loops-Arrays

            string[] courses = { "Basic", "Intermediate", "Advanced","Expert"};

            foreach(string course in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Page Break");



            

            



        }
    }
}
