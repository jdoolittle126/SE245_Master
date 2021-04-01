/*
 * Jonathan Doolittle
 * Professor Lambert
 * Lab 4
 */


using System;
using System.Text.RegularExpressions;

namespace Lab4_Part1
{
    struct Person
    {
        //Give user output to confirm that data was stored within a class object. (You can use the “Public” precursor here, but it is not necessary till Part 2.)
        private String nameFirst, nameMiddle, nameLast, street1, street2, city, state, zip, phone, email;
        public String NameFirst { get { return nameFirst; } set { nameFirst = value; Console.WriteLine($"Changed First Name to {value}"); }}
        public String NameMiddle { get { return nameMiddle; } set { nameMiddle = value; Console.WriteLine($"Changed Middle Name to {value}"); }}
        public String NameLast { get { return nameLast; } set { nameLast = value; Console.WriteLine($"Changed Last Name to {value}"); } }
        public String Street1 { get { return street1; } set { street1 = value; Console.WriteLine($"Changed Street1 to {value}"); } }
        public String Street2 { get { return street2; } set { street2 = value; Console.WriteLine($"Changed Street2 to {value}"); } }
        public String City { get { return city; } set { city = value; Console.WriteLine($"Changed City to {value}"); } }
        public String State { get { return state; } set { state = value; Console.WriteLine($"Changed State to {value}"); } }
        public String Zip { get { return zip; } set { zip = value; Console.WriteLine($"Changed Zip Code to {value}"); } }
        public String Phone { get { return phone; } set { phone = value; Console.WriteLine($"Changed Phone Number to {value}"); } }
        public String Email { get { return email; } set { email = value; Console.WriteLine($"Changed Email to {value}"); } }

    }
}

namespace Lab4_Part2
{
    class Person
    {
        private String nameFirst, nameMiddle, nameLast, street1, street2, city, state, zip, phone, email;
        public String NameFirst { get { return nameFirst; } set { nameFirst = value; Console.WriteLine($"Changed First Name to {value}"); } }
        public String NameMiddle { get { return nameMiddle; } set { nameMiddle = value; Console.WriteLine($"Changed Middle Name to {value}"); } }
        public String NameLast { get { return nameLast; } set { nameLast = value; Console.WriteLine($"Changed Last Name to {value}"); } }
        public String Street1 { get { return street1; } set { street1 = value; Console.WriteLine($"Changed Street1 to {value}"); } }
        public String Street2 { get { return street2; } set { street2 = value; Console.WriteLine($"Changed Street2 to {value}"); } }
        public String City { get { return city; } set { city = value; Console.WriteLine($"Changed City to {value}"); } }
        public String State { get { return state; } set { state = value; Console.WriteLine($"Changed State to {value}"); } }
        public String Zip { get { return zip; } set { zip = value; Console.WriteLine($"Changed Zip Code to {value}"); } }
        public String Phone { get { return phone; } set { phone = value; Console.WriteLine($"Changed Phone Number to {value}"); } }
        public String Email { get { return email; } set { email = value; Console.WriteLine($"Changed Email to {value}"); } }

    }
}

namespace Lab4_Part3
{
    enum DataType
    {
        Name,
        Street,
        City,
        State,
        Zip,
        Phone,
        Email 
    }
    class Person
    {
        private String nameFirst, nameMiddle, nameLast, street1, street2, city, state, zip, phone, email;
        public String NameFirst { get => nameFirst; set { if(Validate(value, DataType.Name)) nameFirst = value; } }
        public String NameMiddle { get => nameMiddle; set { if (Validate(value, DataType.Name)) nameMiddle = value; } }
        public String NameLast { get => nameLast; set { if (Validate(value, DataType.Name)) nameLast = value; } }
        public String Street1 { get => street1; set { if (Validate(value, DataType.Street)) street1 = value; } }
        public String Street2 { get => street2; set { if (Validate(value, DataType.Street)) street2 = value; } }
        public String City { get => city; set { if (Validate(value, DataType.City)) city = value; } }
        public String State { get => state; set { if (Validate(value, DataType.State)) state = value; } }
        public String Zip { get => zip; set { if (Validate(value, DataType.Zip)) zip = value; } }
        public String Phone { get => phone; set { if (Validate(value, DataType.Phone)) phone = value; } }
        public String Email { get => email; set { if (Validate(value, DataType.Email)) email = value; } }

        public Person()
        {

        }

        private bool Validate(string val, DataType type)
        {
            //Not every type of data needs validation, but I included them all for future expansion
            switch(type)
            {
                case DataType.Name:
                    Console.WriteLine($"Value has been set to {val}");
                    return true;
                case DataType.Street:
                    Console.WriteLine($"Value has been set to {val}");
                    return true;
                case DataType.City:
                    Console.WriteLine($"Value has been set to {val}");
                    return true;
                case DataType.State:
                    Console.WriteLine($"Value has been set to {val}");
                    return true;
                case DataType.Zip:
                    Regex zip = new Regex(@"\b[0-9]{5}\b");
                    if (zip.IsMatch(val))
                    {
                        Console.WriteLine($"Zip Code set to {val}");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Zip Code! Use the format 00000, only digits!");
                        return false;
                    }
                case DataType.Phone:
                    Regex phone = new Regex(@"\(?\b([0-9]{3})\)?[-. ]?([0-9]{3})[-.●]?([0-9]{4})\b");
                    if (phone.IsMatch(val))
                    {
                        Console.WriteLine($"Phone Number set to {val}");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Phone Number! Use the format (000) 000-0000!");
                        return false;
                    }
                case DataType.Email:
                    Regex email = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                    if(email.IsMatch(val))
                    {
                        Console.WriteLine($"Email set to {val}");
                        return true;
                    } else
                    {
                        Console.WriteLine("Invalid Email Address! Use the format name@example.com");
                        return false;
                    }
                    
            }
            return false;
        }


    }

}

namespace Lab4_Driver
{
    class Program
    {

        public static void Pause()
        {
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
        }
        static void Main()
        {
            // PART 1
            Console.WriteLine("Lab4 - PART1");
            Lab4_Part1.Person part1 = new Lab4_Part1.Person();
            part1.Email = "jjdoolittle@email.neit.edu";
            part1.NameFirst = "Jonathan";
            part1.NameLast = "Doolittle";
            Pause();

            //PART 2
            Console.WriteLine("Lab4 - PART2");
            Lab4_Part2.Person part2 = new Lab4_Part2.Person();
            part2.Email = "jjdoolittle@email.neit.edu";
            part2.NameFirst = "Jonathan";
            part2.NameLast = "Doolittle";

            part2.NameFirst += "Poopy";

            Pause();

            //PART 3
            Console.WriteLine("Lab4 - PART3");
            Lab4_Part3.Person part3 = new Lab4_Part3.Person();
            part3.Email = "invalid";
            part3.Email = "valid@example.com";
            part3.NameFirst = "First Name";
            part3.Phone = "incorrect";
            part3.Phone = "(123) 456-7890";
            part3.Zip = "00w00";
            part3.Zip = "12345";
            Pause();




        }
    }
}