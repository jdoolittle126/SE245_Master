using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DoolittleSE245.Core;

namespace DoolittleSE245.DataValidation
{
    class Validation
    {

        public static (bool valid, string feedback) IsMatch(string a, string b)
        {
            bool x = a.Equals(b);
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_MATCH);
        }

        public static (bool valid, string feedback) IsFutureDate(DateTime v)
        {
            bool x = v.CompareTo(DateTime.Today) > 0;
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_FUTUREDATE);
        }

        public static (bool valid, string feedback) IsPositive(string v)
        {
            bool x = (v.Contains(".")) ?
                double.TryParse(v, out double a) && IsPositive(a).valid :
                int.TryParse(v, out int b) && IsPositive(b).valid;
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_POSITIVE);
        }

        public static (bool valid, string feedback) IsPositive(int v)
        {
            bool x = v >= 0;
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_POSITIVE);
        }

        public static (bool valid, string feedback) IsPositive(double v)
        {
            bool x = v >= 0;
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_POSITIVE);
        }

        public static (bool valid, string feedback) IsDate(string v)
        {
            bool x = DateTime.TryParse(v, out _);
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_DATE);
        }

        public static (bool valid, string feedback) IsReleventDate(string v)
        {
            (bool valid, string feedback) a = IsDate(v), b = IsFutureDate(DateTime.Parse(v));
            bool x = a.valid && ! b.valid;
            return (x, (x) ? Constants.FEEDBACK_VALID : (a.valid) ? b.feedback : a.feedback);
        }

        public static (bool valid, string feedback) IsValidateName(string v)
        {
            bool x = v.Length > 0;
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_NAME);
        }

        public static (bool valid, string feedback) IsValidateStreet(string v)
        {
            bool x = v.Length > 0;
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_STREET);
        }

        public static (bool valid, string feedback) IsValidateCity(string v)
        {
            bool x = v.Length > 0;
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_CITY);
        }

        public static (bool valid, string feedback) IsValidateState(string v)
        {
            bool x = new Regex(@"\b[A-Z, a-z]{2}\b").IsMatch(v);
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_STATE);
        }

        public static (bool valid, string feedback) IsValidateZipCode(string v)
        {
            bool x = new Regex(@"\b[0-9]{5}\b").IsMatch(v);
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_ZIP);
        }

        public static (bool valid, string feedback) IsValidateEmail(string v)
        {
            bool x = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").IsMatch(v);
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_EMAIL);
        }

        public static (bool valid, string feedback) IsValidatePhone(string v)
        {
            bool x = new Regex(@"\(?\b([0-9]{3})\)?[-. ]?([0-9]{3})[-.●]?([0-9]{4})\b").IsMatch(v);
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_PHONE);
        }

        public static (bool valid, string feedback) IsURL(string v)
        {
            bool x = Uri.IsWellFormedUriString(v, UriKind.Absolute);
            return (x, (x) ? Constants.FEEDBACK_VALID : Constants.FEEDBACK_URL);
        }

        public static (bool valid, string feedback) IsSiteURL(string v, string site)
        {
            (bool valid, string feedback) = IsURL(v); 
            bool x = valid && v.Contains(site);
            return (x, (x) ? Constants.FEEDBACK_VALID : (valid) ? $"The URL must contain {site}" : feedback);
        }

    }


}
