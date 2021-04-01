using DoolittleSE245.Core;
using DoolittleSE245.DataValidation;
using System;

namespace DoolittleSE245.Entities
{
    public class Person
    {
        private string nameFirst, nameMiddle, nameLast, street1, street2, city, state, zip, phone, email;
        protected bool valid;
        public string NameFirst { get => nameFirst; }
        public string NameMiddle { get => nameMiddle; }
        public string NameLast { get => nameLast; }
        public string Street1 { get => street1; }
        public string Street2 { get => street2; }
        public string City { get => city; }
        public string State { get => state; }
        public string Zip { get => zip; }
        public string Phone { get => phone; }
        public string Email { get => email; }

        public bool SetNameFirst(string val)
        {
            bool x = Validation.IsValidateName(val).valid;
            nameFirst = x ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetNameMiddle(string val)
        {
            bool x = Validation.IsValidateName(val).valid || val.Length == 0;
            nameMiddle = x ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetNameLast(string val)
        {
            bool x = Validation.IsValidateName(val).valid;
            nameLast = x ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetStreet1(string val)
        {
            bool x = Validation.IsValidateStreet(val).valid;
            street1 = x ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetStreet2(string val)
        {
            bool x = Validation.IsValidateStreet(val).valid || val.Length == 0;
            street2 = x ? val : Constants.TEXT_INVALID;
            //return x;
            return true; //Temp for now, street2 not required
        }
        public bool SetCity(string val)
        {
            bool x = Validation.IsValidateCity(val).valid;
            city = x ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetState(string val)
        {
            bool x = Validation.IsValidateState(val).valid;
            state = x ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetZip(string val)
        {
            bool x = Validation.IsValidateZipCode(val).valid;
            zip = x ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetPhone(string val)
        {
            bool x = Validation.IsValidatePhone(val).valid;
            phone = x ? val : Constants.TEXT_INVALID;
            return x;
        }
        public bool SetEmail(string val)
        {
            bool x = Validation.IsValidateEmail(val).valid;
            email = x ? val : Constants.TEXT_INVALID;
            return x;
        }

        //public bool IsPropertyValid()

        public Person()
        {
            valid = true;
        }

        public Person(string nameFirst, string nameMiddle, string nameLast, string street1, string street2, string city, string state, string zip, string phone, string email)
        {
            valid =
            SetNameFirst(nameFirst) &&
            SetNameMiddle(nameMiddle) &&
            SetNameLast(nameLast) &&
            SetStreet1(street1) &&
            SetStreet2(street2) &&
            SetCity(city) &&
            SetState(state) &&
            SetZip(zip) &&
            SetPhone(phone) &&
            SetEmail(email);
        }

        //Forces re-check of validity
        public virtual bool CheckValidity()
        {
            valid =
                SetNameFirst(nameFirst) &&
                SetNameMiddle(nameMiddle) &&
                SetNameLast(nameLast) &&
                SetStreet1(street1) &&
                SetStreet2(street2) &&
                SetCity(city) &&
                SetState(state) &&
                SetZip(zip) &&
                SetPhone(phone) &&
                SetEmail(email);
            return valid;
        }

        //Gets validity without checking
        public bool GetValidity()
        {
            return valid;
        }

        public override string ToString()
        {
            //Just for organization sake
            string name = $" * NAME INFROMATION\n\tFirst Name: {NameFirst}\n\tMiddle Name: {NameMiddle}\n\tLast Name: {NameLast}\n";
            string addr = $"* ADDRESS INFROMATION\n\tStreet1: {Street1}\n\tStreet2: {Street2}\n\tCity: {City}\n\tState: {State}\n\tZip Code: {Zip}\n";
            string cont = $"* CONTACT INFROMATION\n\tEmail: {Email}\n\tPhone: {Phone}";

            return name + addr + cont;
        }

    }
}
