using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook_UC_10
{
   public class Program
    {
       public static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            listPersonsInCity.Add(new Person("Ajith", "Kumar", "123,abc.", "8456974123", "Salem", "TamilNadu", "636402", "abc@gmail.com"));
            listPersonsInCity.Add(new Person("Raj", "Ram", "134.sdf", "7896541235", "Kochi", "Kerala", "621654", "qwe@gmail.com"));
            listPersonsInCity.Add(new Person("Vijay", "Kamal", "143,ghj.", "9584235874", "Bangalore", "Karnataka", "635541", "bac@gmail.com"));

            Console.WriteLine("Find a Contact Number of a Person in State Karnataka ");
            foreach (Person person in listPersonsInCity.FindAll(e => (e.State == "Karnataka")).Take(1).ToList())
            {
                Console.WriteLine("Number : " + person.MobileNumber);
            }
        }
    }
}
