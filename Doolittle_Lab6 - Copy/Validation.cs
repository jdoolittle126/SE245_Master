using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibValidation
{
    class Validation
    {

        public static bool IsMatch(string a, string b)
        {
            return a.Equals(b);
        }

        public static bool IsFutureDate(DateTime v)
        {
            return v.CompareTo(DateTime.Today) > 0;
        }

        public static bool IsPositive(string v)
        {
            if (v.Contains(".")) return Double.TryParse(v, out double x) && IsPositive(x);
            else return int.TryParse(v, out int x) && IsPositive(x);
        }

        public static bool IsPositive(int v)
        {
            return v >= 0;
        }

        public static bool IsPositive(double v )
        {
            return v >= 0;
        }

        public static bool IsDate(string v)
        {
            return DateTime.TryParse(v, out _);
        }

        public static bool IsReleventDate(string v)
        {
            return IsDate(v) && !IsFutureDate(DateTime.Parse(v));
        }

        public static bool IsValidateName(string v)
        {
            return v.Length > 0;
        }

        public static bool IsValidateStreet(string v)
        {
            return v.Length > 0;
        }

        public static bool IsValidateCity(string v)
        {
            return v.Length > 0;
        }

        public static bool IsValidateState(string v)
        {
            return new Regex(@"\b[A-Z, a-z]{2}\b").IsMatch(v);
        }

        public static bool IsValidateZipCode(string v)
        {
            return new Regex(@"\b[0-9]{5}\b").IsMatch(v);
        }

        public static bool IsValidateEmail(string v)
        {
            return new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").IsMatch(v);
        }

        public static bool IsValidatePhone(string v)
        {
            return new Regex(@"\(?\b([0-9]{3})\)?[-. ]?([0-9]{3})[-.●]?([0-9]{4})\b").IsMatch(v);
        }

        public static bool IsURL(string v)
        {
            return Uri.IsWellFormedUriString(v, UriKind.Absolute);
        }

        public static bool IsSiteURL(string v, string site)
        {
            return IsURL(v) && v.Contains(site);
        }

    }


}
