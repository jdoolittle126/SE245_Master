using DoolittleSE245.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoolittleSE245.Core
{
    class TablePopulator
    {
        static string[] firstnames = { "Alina", "Amelia", "Alexander", "Adrianna", "Alen", "Michael", "Tony", "Kimberly", "Chelsea", "Arnold", "Garry", "Alberta", "Jasmine", "Ryan", "Eddy", "Cherry", "Daryl", "Ryan", "Andrew", "Adele", "Steven", "Tara", "Ellia", "Luke", "Roman", "Sienna", "Audrey", "Oscar", "Jasmine", "Kelsey", "Darcy", "Maximilian", "Alina", "Kate", "Justin", "Cadie", "Aston", "Cadie", "Olivia", "Alford" };
        static string[] lastnames = { "Walker", "Phillips", "Harris", "Fowler", "Barnes", "Martin", "Nelson", "Ross", "Myers", "Montgomery", "Warren", "Johnson", "Scott", "Gibson", "Hunt", "Davis", "Wright", "Ross", "West", "West", "Cameron", "Brown", "Johnson", "Richardson", "Johnston", "Chapman", "Craig", "Clark", "Cole", "Miller", "Davis", "Stevens", "Morris", "Walker", "Harris", "Owens", "Riley", "Stewart", "Murphy", "Johnston" };
        static string[] streets = { "Glendale", "Main", "Harris", "George", "Bald Hill", "Cooper", "Sunway", "Holy View", "Crest", "Sand", "Sunny", "Red" };
        static string[] streettype = { "Street", "Drive", "Court", "Lane", "Avenue", "Ave.", "Rd.", "St.", "Parkway" };
        static string[] cities = { "Mobridge", "Sunnyvale", "Jim Thorpe", "Tooele", "Simi Valley", "Greeley", "San Bernardino", "Chanute", "Sheridan", "Bisbee", "Piqua", "Harpers Ferry", "Baltimore ", "Winooski ", "Virginia City", "South Charleston", "Vernal", "Atchison", "Naples", "Glendive" };
        static string[] states = { "AL","MO","AK","MT","AZ","NE","AR","NV","CA","NH","CO","NJ"};
        public static void PopulateRandom(int count)
        {
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                
                string first = firstnames[r.Next(firstnames.Length)];
                string last = lastnames[r.Next(lastnames.Length)];

                PersonV2 tmp = new PersonV2();
                tmp.SetNameFirst(first);
                tmp.SetNameMiddle("");
                tmp.SetNameLast(last);
                tmp.SetStreet1($"{r.Next(4000) + 1} {streets[r.Next(streets.Length)]} {streettype[r.Next(streettype.Length)]}");
                tmp.SetStreet2("");
                tmp.SetCity(cities[r.Next(cities.Length)]);
                tmp.SetState(states[r.Next(states.Length)]);
                tmp.SetZip($"{r.Next(10000, 100000)}");
                tmp.SetPhone($"({r.Next(100, 1000)}) {r.Next(100, 1000)}-{r.Next(1000, 10000)}");
                tmp.SetEmail($"{first.Substring(0, 1).ToLower()}.{last.ToLower()}@scotticus.gov");
                tmp.SetMobile($"({r.Next(100, 1000)}) {r.Next(100, 1000)}-{r.Next(1000, 10000)}");
                tmp.SetInstagramURL($"https://instagram.com/{ first + last}");
                Program.database.AddPerson(tmp, out bool _);
            }

            
        }
       


    }
}
