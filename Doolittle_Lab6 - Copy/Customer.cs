using Doolittle_Lab6;
using LibValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doolittle_Lab5
{
    class Customer : PersonV2
    {
        private DateTime customerSince;
        private double totalPurchases;
        private bool discountMember;
        private int rewardsEarned;

        public DateTime CustomerSince { get => customerSince; }
        public double TotalPurchases { get => totalPurchases; }
        public bool IsDiscountMember { get => discountMember;}
        public int RewardsEarned { get => rewardsEarned; }

        public bool SetCustomerSince(DateTime val)
        {
            bool x = Validation.IsFutureDate(val);
            customerSince = (x) ? val : (customerSince.Equals(null) ? DateTime.Now : customerSince);
            return x;
        }

        public bool SetTotalPurchases(string val)
        {
            bool x = Validation.IsPositive(val);
            if (x) double.TryParse(val, out totalPurchases);
            else totalPurchases = 0;
            return x;
        }

        public bool SetDiscountMember(bool val)
        {
            discountMember = val;
            return true;
        }

        public bool SetRewardsEarned(string val)
        {
            bool x = Validation.IsPositive(val);
            if(x) int.TryParse(val, out rewardsEarned);
            else rewardsEarned = 0;
            return x;
        }

        public Customer(string nameFirst, string nameMiddle, string nameLast, string street1, string street2, string city, string state, string zip, string phone, string email, string mobile, string instagramURL) :
            base(nameFirst, nameMiddle, nameLast, street1, street2, city, state, zip, phone, email, mobile, instagramURL)
        {
            customerSince = DateTime.Now;
        }

        public Customer(string nameFirst, string nameMiddle, string nameLast, string street1, string street2, string city, string state, string zip, string phone, string email, string mobile, string instagramURL, DateTime customerSince, string totalPurchases, bool discountMember, string rewardsEarned) :
               base(nameFirst, nameMiddle, nameLast, street1, street2, city, state, zip, phone, email, mobile, instagramURL)
        {
            SetCustomerSince(customerSince);
            SetTotalPurchases(totalPurchases);
            SetRewardsEarned(rewardsEarned);
            SetDiscountMember(discountMember);
        }

        public void IncrementPurchase(double cost)
        {
            totalPurchases += cost;
        }

        public void AddRewardsEarned()
        {
            rewardsEarned++;
        }
        public void AddRewardsEarned(int val)
        {
            rewardsEarned += val;
        }

        public override string ToString()
        {

           return base.ToString() +  $" * CUSTOMER DATA\n\tCustomer Since: {CustomerSince}\n\tTotal Purchases: ${TotalPurchases}\n\tDiscount Member: {IsDiscountMember}\n\tRewards Earned: {RewardsEarned}\n";

        }



    }
}
