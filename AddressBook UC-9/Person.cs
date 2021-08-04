using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_UC_9
{
   public class Person
    {
       public string FirstName;
       public string LastName;
       public string Address;
       public string MobileNumber;
       public string City;
       public string State;
       public string PinCode;
       public string EMail;

        public Person(string firstName, string lastName, string address, string mobileNumber, string city, string state, string pinCode, string eMail)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            MobileNumber = mobileNumber;
            City = city;
            State = state;
            PinCode = pinCode;
            EMail = eMail;
        }

    }
}
