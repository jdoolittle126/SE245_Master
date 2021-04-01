/*
 * Jonathan Doolittle
 * Dr. Lambert
 * Lab 1
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean running = true;
            Double[] weights = { 0.2, 0.2, 0.25, 0.35 };
            Double[] grades = new Double[4]; ;
            String studentName;

            while (running)
            {

                Console.Write("\n -- This program will help you calculate a student's weighted average -- \n\nThe weights are as follows:\nGrade 1 - 20%\nGrade 2 - 20%\nGrade 3 - 25%\nGrade 4 - 35%\n\nPlease enter your student's name: ");
                studentName = Console.ReadLine();
                Console.WriteLine($"Great! Let's get started on {studentName}'s grades!");

                for(int i = 0; i < weights.Length; i++)
                {
                    grades[i] = getInput(i) * weights[i];
                }

                // 0 2.5 7.5

                Double grade = Math.Clamp(grades.Sum(), 0, 100);
                Double grade_base = Convert.ToInt32(Math.Floor(grade / 10));
                String variation = "";
                if(grade - (grade_base*10) < 3) variation = "-";
                else if(grade - (grade_base * 10) >= 7) variation = "+";

                Console.Write($"\nHere is {studentName}'s final grade!\nGrade - {grade}\nLetter - ");


                switch(grade_base)
                {
                    case 10:
                        Console.Write("A+");
                        break;
                    case 9:
                        Console.Write($"A{variation}");
                        break;
                    case 8:
                        Console.Write($"B{variation}");
                        break;
                    case 7:
                        Console.Write($"C{variation}");
                        break;
                    case 6:
                        Console.Write($"D{variation}");
                        break;
                    default:
                        Console.Write("F");
                        break;
                }
                
                
                Console.WriteLine($"\n\nWould you like to calculate another average? (Y/N)");
                if (Console.ReadLine() == "N") running = false;

            }



        }

        static Double getInput(int i)
        {
            Double grade;
            Console.Write($"\nEnter Grade {i+1}: ");
            String val = Console.ReadLine();

            if (Double.TryParse(val, out grade)) return grade;
            else
            {
                Console.WriteLine("That doesn't look quite right, let's try again!");
                return getInput(i);
            }
        }


    }
}
