/*
 * Tim LeBrun
 * Jonathan Doolittle
 * Dr. Lambert
 * Calculator Fixes
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true, initial =  true;

            String strFirst, strOperand, strNum1, strNum2;
            Int32 intNum1 = 0, intNum2 = 0;
            Double dblResult = 0;

            Console.WriteLine("Hello There!");

            Console.Write("Please enter your first name: ");
            strFirst = Console.ReadLine();

            Console.WriteLine("Hello " + strFirst + "! Let's do some math!");


            while (running)
            {
                if(!initial)
                {
                    Console.WriteLine("Welcome back " + strFirst + "! Let's do some more math!");
                } else
                {
                    initial = false;
                }

                Console.Write("Please enter the first number: ");
                strNum1 = Console.ReadLine();

                Console.Write("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
                strOperand = Console.ReadLine();

                Console.Write("Please enter the second number: ");
                strNum2 = Console.ReadLine();

                try
                {
                    intNum1 = Int32.Parse(strNum1);
                    intNum2 = Convert.ToInt32(strNum2);
                } catch (Exception)
                {
                    Console.WriteLine("Whoops! Looks like something went wrong, check your values, then try again!");
                    break;
                }



                switch (strOperand)
                {
                    case "PLUS":
                        dblResult = intNum1 + intNum2;
                        break;
                    case "MINUS":
                        dblResult = intNum1 - intNum2;
                        break;
                    case "DIVIDE":
                        dblResult = (Double)intNum1 / intNum2;
                        break;
                    case "MULTIPLY":
                        dblResult = intNum1 * intNum2;
                        break;
                    default:
                        Console.WriteLine("Whoops! Looks like something went wrong, check your operation, then try again!");
                        break;
                }

                if (strOperand == "PLUS")
                {
                    Console.Write("\n\nThe sum of " + intNum1 + " and " + intNum2 + " equals: " + dblResult);
                }
                else if (strOperand == "MINUS")
                {
                    Console.Write("\n\nThe difference of " + intNum1 + " and " + intNum2 + " equals: " + dblResult);
                }
                else if (strOperand == "DIVIDE")
                {
                    Console.WriteLine($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");
                }
                else if (strOperand == "MULTIPLY")
                {
                    Console.WriteLine($"\n\nThe product of {intNum1} and {intNum2} equals: {dblResult}");
                } else
                {
                    running = false;
                }
                Console.WriteLine($"\nDo more math? (Y / N)");
                running = (Console.ReadLine() == "Y") ? true : false;

            }

            Console.WriteLine($"\n\nPress Any Key to Continue");
            Console.ReadKey();

        }


    }
}
   