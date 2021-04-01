using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Doolittle_Lab5
{
    class Person
    {
        public String NameFirst { get; set; }
        public String NameMiddle { get; set; }
        public String NameLast { get; set; }
        public String Street1 { get; set; }
        public String Street2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }


        public string Print()
        {
            //Just for organization sake
            string name = $" * NAME INFROMATION\n\tFirst Name: {NameFirst}\n\tMiddle Name: {NameMiddle}\n\tLast Name: {NameLast}\n";
            string addr = $"* ADDRESS INFROMATION\n\tStreet1: {Street1}\n\tStreet2: {Street2}\n\tCity: {City}\n\tState: {State}\n\tZip Code: {Zip}\n";
            string cont = $"* CONTACT INFROMATION\n\tEmail: {Email}\n\tPhone: {Phone}";

            return name+addr+cont;
        }

        public bool ValidateName()
        {
            //No Validation Needed!
            return true;
        }

        public bool ValidateStreet()
        {
            //No Validation Needed!
            return true;
        }

        public bool ValidateCity()
        {
            //No Validation Needed!
            return true;
        }

        public bool ValidateState()
        {
            return new Regex(@"\b[A-Z, a-z]{2}\b").IsMatch(State);
        }

        public bool ValidateZipCode()
        {
            return new Regex(@"\b[0-9]{5}\b").IsMatch(Zip);
        }

        public bool ValidateEmail()
        {
            return new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").IsMatch(Email);
        }

        public bool ValidatePhone()
        {
            return new Regex(@"\(?\b([0-9]{3})\)?[-. ]?([0-9]{3})[-.●]?([0-9]{4})\b").IsMatch(Phone);
        }
    }
}
