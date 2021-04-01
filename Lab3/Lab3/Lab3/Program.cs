/*
 * 
 * Jonathan Doolittle
 * Professor Lambert
 * Lab 3
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace Lab3
{
    class Task
    {
        static List<String> global_tags = new List<String>();
        List<String> tags;
        String name;
        double time_to_complete;

        public Task(String name, double time_to_complete)
        {
            Tags = new List<String>();
            this.Name = name;
            this.time_to_complete = time_to_complete;
        }

        public static List<string> Global_tags { get => global_tags; set => global_tags = value; }
        public string Name { get => name; set => name = value; }
        public double Time_to_complete { get => time_to_complete; set => time_to_complete = value; }
        public List<string> Tags { get => tags; set => tags = value; }

        public void AddTag(string tag, ref int tag_count)
        {
            Tags.Add(tag);
            if(!Global_tags.Contains(tag))
            {
                Global_tags.Add(tag);
                tag_count++;
            }
        }

    }

    class Program
    {

        static void Pause()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static bool Continue(string text)
        {
            Console.Write($"Would you like to enter {text}? (y/n) ");
            return (Console.ReadLine().Trim().ToLower() == "y");
        }

        static int Menu()
        {
            int x;
            do
            {
                Console.Clear();
                Console.WriteLine("Here you can view info about your tasks! Please enter the number of the stat you would like to see!");
                Console.WriteLine("1.) Total Time of Tasks");
                Console.WriteLine("2.) Average Time per Task");
                Console.WriteLine("3.) Number of Tags");
                Console.WriteLine("4.) All Tasks");
                Console.WriteLine("5.) All Tags");
                Console.WriteLine("6.) Filter by Tag");
                Console.WriteLine("7.) Quit");
            } while (!int.TryParse(Console.ReadLine(), out x));
            return x;

        }

        static double GetTotal(List<Task> tasks)
        {
            double total = 0;
            foreach (Task t in tasks)
            {
                total += t.Time_to_complete;
            }
            return total;
        }

        static void Main(string[] args)
        {
            int tag_count = 0;
            List<Task> tasks = new List<Task>();
            Console.WriteLine("Welcome to your To-Do List! Please enter a task, an estimated time for completion, and 1 or more tags!");

            do
            {
                Console.Write("Enter the name of your task: ");
                String name = Console.ReadLine();
                double t;
                do
                {
                    Console.Write("\nGive a time estimate on how long your task will take to complete (min): ");
                } while (!Double.TryParse(Console.ReadLine(), out t));
                Task tmp = new Task(name, t);

                while(Continue("new tag"))
                {
                    Console.Write("\nEnter the name of your tag: ");
                    tmp.AddTag(Console.ReadLine(), ref tag_count);
                }

                tasks.Add(tmp);

            } while (Continue("another task"));

            bool running = true;
            
            while(running)
            {
                switch (Menu())
                {
                    case 1:
                        Console.WriteLine($"It will take {GetTotal(tasks)} mins to complete all tasks!");
                        Pause();
                        break;
                    case 2:
                        Console.WriteLine($"On average, each task will take {Math.Round(GetTotal(tasks) / tasks.Count, 2)} mins!");
                        Pause();
                        break;
                    case 3:
                        Console.WriteLine($"You have a total of {tag_count} tags!");
                        Pause();
                        break;
                    case 4:
                        foreach (Task t in tasks)
                        {
                            Console.Write($"[TASK] {t.Name}\n --- [TIME] {t.Time_to_complete} mins\n --- [TAGS] ");
                            t.Tags.ForEach(delegate (String s) {Console.Write(s + " ");});
                            Console.Write("\n");
                        }
                        Pause();
                        break;
                    case 5:

                        Task.Global_tags.ForEach(delegate (String s) { Console.WriteLine(s); });
                        Pause();
                        break;
                    case 6:

                        Console.Write("Enter a tag to search: ");
                        String search = Console.ReadLine().Trim();
                        foreach (Task t in tasks)
                        {
                            if(t.Tags.Contains(search))
                            {
                                Console.WriteLine(t.Name);
                            }
                        }

                        Pause();
                         break;
                    default:
                        running = false;
                        break;
                }
            }




        }
            

    }
}
