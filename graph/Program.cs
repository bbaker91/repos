//Date              Developer           Description
//2019-1-22         BBradley Baker      Opened file and started layout of program. Added while, for and if statments
//                                      completed all sections, tested and implemented.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarGraph
{
    class BarGraph
    {
        static void Main(string[] args)
        {
            // Tell the user about the program
            //tell the user how to use the program
            Console.WriteLine(
@" Welcome to the Astrick Bar Graph program. You will be asked to enter in three numbers that are in the range 1-30. 
Enter in Whole Numbers when inputting your values. If the number entered is not between 1 and 30 then you will be asked to try again.

");
            //set my variable
            string number1 = "fail";
            string number2 = "fail";
            string number3 = "fail";
            string message = "Enter in your number ";
            //output for graph


            //Get three numberers between 1 and 30 from the user
            //Verify
            for (int i = 1; i <= 3; ++i)
            {
                if (i == 1)
                {
                    while (number1 == "fail")
                    {
                        Console.WriteLine($"{message}");
                        number1 = validate(int.Parse(Console.ReadLine()));

                    }
                }

                else if (i == 2)
                {
                    number2 = validate(int.Parse(Console.ReadLine()));
                }
                else
                {
                    number3 = validate(int.Parse(Console.ReadLine()));
                }
                // get input numbers from user
                //verify that each number is in the range 1-30



            }
            Console.WriteLine($"{number1}");
            Console.WriteLine($"{number2}");
            Console.WriteLine($"{number3}");

            Console.ReadLine();

        }
        public static string validate(int number)
        {

            string output = "";
            if (number >= 1 && number <= 30)
            {
                for (int b = 1; b <= number; ++b)
                {
                    output += $"*";
                }

            }
            else
                output = "Fail";

            return output;
        }

        public static string userMessages(string result, int num)
        {

            string output = "";

            if (result == "fail")
            {
                output = "Not valid number please enter ";
            }
            else {
                output = "success";
            }


            return output;



        }
    }
}


