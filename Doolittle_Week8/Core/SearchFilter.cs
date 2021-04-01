using DoolittleSE245.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoolittleSE245.Core
{

    public class SearchFilters
    {



        public static SearchFilter NameFirst()
        {
            return new SearchFilter("Search by first name", "FirstName");
        }
        public static SearchFilter NameMiddle()
        {
            return new SearchFilter("Search by middle name", "MiddleName");
        }
        public static SearchFilter NameLast() { return new SearchFilter("Search by last name", "LastName"); }
        public static SearchFilter Street1() { return new SearchFilter("Search by street1", "Street1"); }
        public static SearchFilter Street2() { return new SearchFilter("Search by street2", "Street2"); }
        public static SearchFilter City() { return new SearchFilter("Search by city", "City"); }
        public static SearchFilter State() { return new SearchFilter("Search by state", "State"); }
        public static SearchFilter Zip() { return new SearchFilter("Search by zipcode", "Zip"); }

        public static SearchFilter PhoneHome()
        {
            return new SearchFilter("Search for by home phone", "HomePhone");
        }
        public static SearchFilter PhoneMobile()
        {
            return new SearchFilter("Search by mobile phone", "MobilePhone"); }
        public static SearchFilter Email()
        {
            return new SearchFilter("Search by email", "Email"); }
        public static SearchFilter Instagram()
        {
            return new SearchFilter("Search by instagram URL", "InstagramURL");
        }

        public static SearchFilter PhoneAny()
        {
            SearchFilter tmp = new SearchFilter("Search all phone fields");
            Console.WriteLine("MEEP " + PhoneHome().Columns.Concat(PhoneHome().Columns.ToList()));
            tmp.Columns.AddRange(PhoneHome().Columns);
            tmp.Columns.AddRange(PhoneMobile().Columns);
            return tmp;
        }
        public static SearchFilter StreetAny()
        {
            SearchFilter tmp = new SearchFilter("Search all street fields");
            tmp.Columns.AddRange(Street1().Columns);
            tmp.Columns.AddRange(Street2().Columns);
            return tmp;

        }
        public static SearchFilter NameAny()
        {
            SearchFilter tmp = new SearchFilter("Search all name fields");
            tmp.Columns.AddRange(NameFirst().Columns);
            tmp.Columns.AddRange(NameMiddle().Columns);
            tmp.Columns.AddRange(NameLast().Columns);
            return tmp;
        }
        public static SearchFilter Any() {
            SearchFilter tmp = new SearchFilter("Search all fields");
            tmp.Columns.AddRange(NameAny().Columns);
            tmp.Columns.AddRange(StreetAny().Columns);
            tmp.Columns.AddRange(City().Columns);
            tmp.Columns.AddRange(State().Columns);
            tmp.Columns.AddRange(Zip().Columns);
            tmp.Columns.AddRange(PhoneAny().Columns);
            tmp.Columns.AddRange(Email().Columns);
            tmp.Columns.AddRange(Instagram().Columns);
            return tmp;
        }

    }

public class SearchFilter
    {
        public string Filter { get; set; }
        public List<string> Columns = new List<string>();
        public SearchFilter(string filter) { Filter = filter; }
        public SearchFilter(string filter, string col) { Filter = filter; Columns.Add(col); }

        public static List<SearchFilter> Filters = new List<SearchFilter>()
        {
            SearchFilter.Any,
            SearchFilter.NameAny,
            SearchFilter.NameFirst,
            SearchFilter.NameMiddle,
            SearchFilter.NameLast,
            SearchFilter.StreetAny,
            SearchFilter.Street1,
            SearchFilter.Street2,
            SearchFilter.City,
            SearchFilter.State,
            SearchFilter.Zip,
            SearchFilter.PhoneAny,
            SearchFilter.PhoneHome,
            SearchFilter.PhoneMobile,
            SearchFilter.Email,
            SearchFilter.Instagram
        };


        public static SearchFilter Any { get { return SearchFilters.Any(); } }
        public static SearchFilter NameAny { get { return SearchFilters.NameAny(); } }
        public static SearchFilter NameFirst { get { return SearchFilters.NameFirst(); } }
        public static SearchFilter NameMiddle { get { return SearchFilters.NameMiddle(); } }
        public static SearchFilter NameLast { get { return SearchFilters.NameLast(); } }
        public static SearchFilter StreetAny { get { return SearchFilters.StreetAny(); } }
        public static SearchFilter Street1 { get { return SearchFilters.Street1(); } }
        public static SearchFilter Street2 { get { return SearchFilters.Street2(); } }
        public static SearchFilter City { get { return SearchFilters.City(); } }
        public static SearchFilter State { get { return SearchFilters.State(); } }
        public static SearchFilter Zip { get { return SearchFilters.Zip(); } }
        public static SearchFilter PhoneAny { get { return SearchFilters.PhoneAny(); } }
        public static SearchFilter PhoneHome { get { return SearchFilters.PhoneHome(); } }
        public static SearchFilter PhoneMobile { get { return SearchFilters.PhoneMobile(); } }
        public static SearchFilter Email { get { return SearchFilters.Email(); } }
        public static SearchFilter Instagram { get { return SearchFilters.Instagram(); } }

        public override string ToString()
        {
            return this.Filter;
        }

        public bool Equals(SearchFilter obj)
        {
            return obj.Filter.Equals(this.Filter);
        }

        public static bool Equals(SearchFilter obj1, SearchFilter obj2)
        {
            return obj1.Filter.Equals(obj2.Filter);
        }



    }
}
