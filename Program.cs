using System;

namespace ISM4300_Deliverable2_Degenbaeva
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input for a grade
            Console.WriteLine("What grade do you expect in ISM4300? ");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather the user input
                int grade = int.Parse(Console.ReadLine());

                // Here's the grading criteria according to the syllabus
                if (grade > 97 && grade < 101)
                {
                    Console.WriteLine("You are going to get an A+");
                }
                else if (grade > 91 && grade < 98)
                {
                    Console.WriteLine("You are going to get an A");
                }
                else if (grade > 89 && grade < 92)
                {
                    Console.WriteLine("You are going to get an A-");
                }
                else if (grade > 87 && grade < 90)
                {
                    Console.WriteLine("You are going to get an B+");
                }
                else if (grade > 81 && grade < 88)
                {
                    Console.WriteLine("You are going to get an B");
                }
                else if (grade > 79 && grade < 82)
                {
                    Console.WriteLine("You are going to get an B-");
                }
                else if (grade > 77 && grade < 80)
                {
                    Console.WriteLine("You are going to get an C+");
                }
                else if (grade > 71 && grade < 78)
                {
                    Console.WriteLine("You are going to get an C");
                }
                 else if (grade > 69 && grade < 72)
                {
                    Console.WriteLine("You are going to get an C-");
                }
                 else if (grade > 67 && grade < 70)
                {
                    Console.WriteLine("You are going to get an D+");
                }
                else if (grade > 61 && grade < 68)
                {
                    Console.WriteLine("You are going to get an D");
                }
                else if (grade > 59 && grade < 62)
                {
                    Console.WriteLine("You are going to get an D-");
                }
              
                else if (grade < 60 && grade > 0)
                {
                    Console.WriteLine("You are going to get an F");
                }

            }
            catch
            {
                Console.WriteLine("Contact me for any questions!");
            }
            
        }
    }
}
