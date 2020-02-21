using System;

namespace URLencoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string yn = "y";

            while (yn == "y")
            {
                string project;
                Console.WriteLine("Enter the project name: ");
                project = Console.ReadLine();

                
                while(IsValid(project) != true)
                {
                    Console.WriteLine("Please enter a valid project.");
                    Console.WriteLine("Enter the project name: ");
                    project = Console.ReadLine();
                }

                string activity;
                Console.WriteLine("Enter the activity name: ");
                activity = Console.ReadLine();

                while (IsValid(activity) != true)
                {
                    Console.WriteLine("Please enter a valid activity.");
                    Console.WriteLine("Enter the activity name: ");
                    activity = Console.ReadLine();
                }

                Console.WriteLine("Generating URL...\n");


                string url = ("https://companyserver.com/content/") + project + ("/files/") + activity + "/" + activity + "report";
                Console.WriteLine("{0}", url);


                Console.WriteLine("Would you like to do another? type y/n: ");
                yn = Console.ReadLine();
            }
        }
        static bool IsValid(string input)
        {
            foreach(char character in input.ToCharArray())
            {
                if (character == 0x1F)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
