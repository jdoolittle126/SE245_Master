using Doolittle_Lab6;
using LibValidation;
using System;



namespace Doolittle_Lab5
{
    class Person
    {

        private String nameFirst, nameMiddle, nameLast, street1, street2, city, state, zip, phone, email;

        public string NameFirst { get => nameFirst; }
        public string NameMiddle { get => nameMiddle;}
        public string NameLast { get => nameLast; }
        public string Street1 { get => street1;}
        public string Street2 { get => street2;}
        public string City { get => city; }
        public string State { get => state; }
        public string Zip { get => zip; }
        public string Phone { get => phone; }
        public string Email { get => email; }

        public bool SetNameFirst(string val) 
        {
            bool x = Validation.IsValidateName(val);
            nameFirst = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetNameMiddle(string val) 
        {
            bool x = Validation.IsValidateName(val);
            nameMiddle = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetNameLast(string val) 
        {
            bool x = Validation.IsValidateName(val);
            nameLast = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetStreet1(string val)
        {
            bool x = Validation.IsValidateStreet(val);
            street1 = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetStreet2(string val)
        {
            bool x = Validation.IsValidateStreet(val);
            street2 = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetCity(string val)
        {
            bool x = Validation.IsValidateCity(val);
            city = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetState(string val)
        {
            bool x = Validation.IsValidateState(val);
            state = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetZip(string val)
        {
            bool x = Validation.IsValidateZipCode(val);
            zip = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetPhone(string val)
        {
            bool x = Validation.IsValidatePhone(val);
            phone = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetEmail(string val)
        {
            bool x = Validation.IsValidateEmail(val);
            email = (x) ? val : Constants.TEXT_INVALID;
            return x;
        }

        //public bool IsPropertyValid()

        public Person()
        {

        }

        public Person(string nameFirst, string nameMiddle, string nameLast, string street1, string street2, string city, string state, string zip, string phone, string email)
        {
            SetNameFirst(nameFirst);
            SetNameMiddle(nameMiddle);
            SetNameLast(nameLast);
            SetStreet1(street1);
            SetStreet2(street2);
            SetCity(city);
            SetState(state);
            SetZip(zip);
            SetPhone(phone);
            SetEmail(email);
        }

        public override string ToString()
        {
            //Just for organization sake
            string name = $" * NAME INFROMATION\n\tFirst Name: {NameFirst}\n\tMiddle Name: {NameMiddle}\n\tLast Name: {NameLast}\n";
            string addr = $"* ADDRESS INFROMATION\n\tStreet1: {Street1}\n\tStreet2: {Street2}\n\tCity: {City}\n\tState: {State}\n\tZip Code: {Zip}\n";
            string cont = $"* CONTACT INFROMATION\n\tEmail: {Email}\n\tPhone: {Phone}";

            return name+addr+cont;
        }

    }
}
