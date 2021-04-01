using Doolittle_Lab6;
using LibValidation;
using System;



namespace Doolittle_Lab5
{
    class PersonV2 : Person
    {
        private String mobile, instagramURL;

        public string Mobile { get => mobile; }
        public string InstagramURL { get => instagramURL; }

        public bool SetMobile(string val)
        {
            bool x = Validation.IsValidatePhone(val);
            mobile = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }

        public bool SetInstagramURL(string val)
        {
            bool x = Validation.IsSiteURL(val, "instagram.com/");
            instagramURL = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }

        public PersonV2()
        {

        }

        public PersonV2 (string nameFirst, string nameMiddle, string nameLast, string street1, string street2, string city, string state, string zip, string phone, string email, string mobile, string instagramURL) :
            base(nameFirst,  nameMiddle,  nameLast,  street1,  street2,  city,  state, zip,  phone,  email)
        {
            SetInstagramURL(instagramURL);
            SetMobile(mobile);
        }

        public override string ToString()
        {
            return base.ToString() + $"\n\tInstagram URL: {InstagramURL}\n\tMobile Phone: {Mobile}";
        }


    }


}
