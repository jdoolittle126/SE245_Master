using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doolittle_Lab5
{

    //I feel that these validation functions would go better in the person class,
    //However, I am leaving them here to meet the 'Basic_Tools' requirement

    class Basic_Tools
    {

        public static bool ValidateName(string v)
        {
            //No Validation Needed!
            return true;
        }

        public static bool ValidateStreet(string v)
        {
            //No Validation Needed!
            return true;
        }

        public static bool ValidateCity(string v)
        {
            //No Validation Needed!
            return true;
        }

        public static bool ValidateState(string v)
        {
            return new Regex(@"\b[A-Z, a-z]{2}\b").IsMatch(v);
        }

        public static bool ValidateZipCode(string v)
        {
            return new Regex(@"\b[0-9]{5}\b").IsMatch(v);
        }

        public static bool ValidateEmail(string v)
        {
            return new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").IsMatch(v);
        }

        public static bool ValidatePhone(string v)
        {
            return new Regex(@"\(?\b([0-9]{3})\)?[-. ]?([0-9]{3})[-.●]?([0-9]{4})\b").IsMatch(v);
        }

    }



}
