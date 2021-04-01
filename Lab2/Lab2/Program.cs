/*
 * 
 * Jonathan Doolittle
 * Professor Lambert
 * Lab 2
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    class Program
    {
        //Quick, could be refined
        static readonly int CONSOLE_WIDTH = 80;

        static void Main(string[] args)
        {
            bool running = true, collecting = true;
            List<Student> students = new List<Student>();

            do
            {
                for (int i = 0; i < CONSOLE_WIDTH; i++) Console.Write("-");
                Console.WriteLine("\nHello, and welcome to the average student calculator! Let's start!\n");
                do
                {
                    Console.Write("Student Name: ");
                    students.Add(new Student(Console.ReadLine().Trim()));
                    Console.Write("\nGreat! Now lets get started with grading!");

                    for (int i = 0; i < Student.LAB_COUNT; i++)
                    {
                        Console.Write($"\nGrade for Lab {i+1}: ");
                        if (students.Last().AddLab(i, Console.ReadLine().Trim())) ;
                        else
                        {
                            Console.WriteLine("That doesn't look quite right! Lets try again!");
                            i--;
                        }
                    }

                    Console.Write("\nAdd another student? (y/n) ");
                    if (Console.ReadLine().Trim().ToLower() != "y") collecting = false;

                } while (collecting);

                Console.WriteLine("\nOkay, lets take a look at the gradebook!");

                int top = Console.CursorTop;

                int space = top;
                WriteRight(" ------ [AVERAGES]", space++);
                for (int i = 0; i < Student.LAB_COUNT; i++)
                {
                    double sum = 0;
                    foreach (Student s in students)
                    {
                        sum += s.GetLab(i);
                    }

                    WriteRight($"Lab {i+1} | {Math.Round(sum / students.Count, 2)}", space++);
                }

                space = top;

                WriteLeft(" ------ [ROSTER]", space++);
                for (int i = 0; i < students.Count; i++)
                {
                    WriteLeft(students[i].GetName(), space++);
                    for (int j = 0; j < Student.LAB_COUNT; j++)
                    {
                        WriteLeft($" - [Lab {j + 1}] | {students[i].GetLab(j)}", space++);
                    }
                    WriteLeft($" [AVERAGE] | {students[i].GetAverage()}", space++);
                    WriteLeft($"  [LETTER] | {students[i].GetLetter()}", space++);
                }

                Console.Write("\nWould you like to enter another class? (y/n) ");
                if (Console.ReadLine().Trim().ToLower() != "y") running = false;
                Console.Clear();
            } while (running);
        }


        static void WriteLeft(string a, int line)
        {
            Console.SetCursorPosition(0, line);
            Console.WriteLine(a);

        }

        static void WriteRight(string b, int line)
        {
            Console.SetCursorPosition(CONSOLE_WIDTH / 2, line);
            Console.WriteLine(b);
        }
    }


    class Student
    {
        public static int LAB_COUNT = 5;
        string name;
        double[] labs = new double[LAB_COUNT];

        public Student(string _name)
        {
            this.name = _name;
        }


        public string GetName() => name;

        public bool AddLab(int index, string grade)
        {
            try
            {
                labs[index] = Convert.ToDouble(grade);
                return true;
            } catch
            {
                return false;
            }
        }

        public double GetLab(int index) => (labs[index]); 

        public double GetAverage() { return Math.Round(labs.Sum() / LAB_COUNT, 2); }

        public string GetLetter()
        {
            Double grade = Math.Clamp(GetAverage(), 0, 100);
            Double grade_base = Convert.ToInt32(Math.Floor(grade / 10));
            String final;
            String variation = "";
            if (grade - (grade_base * 10) < 3) variation = "-";
            else if (grade - (grade_base * 10) >= 7) variation = "+";

            switch (grade_base)
            {
                case 10:
                    final = "A+";
                    break;
                case 9:
                    final = $"A{variation}";
                    break;
                case 8:
                    final = $"B{variation}";
                    break;
                case 7:
                    final = $"C{variation}";
                    break;
                case 6:
                    final = $"D{variation}";
                    break;
                default:
                    final = "F";
                    break;
            }
            return final;
        }

    }
}
