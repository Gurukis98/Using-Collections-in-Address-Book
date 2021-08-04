using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook_UC_9
{
   public class Program
    {
       public static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            listPersonsInCity.Add(new Person("Ajith", "Kumar", "123,abc.", "8456974123", "Salem", "TamilNadu", "636402", "abc@gmail.com"));
            listPersonsInCity.Add(new Person("Raj", "Ram", "134.sdf", "7896541235", "Kochi", "Kerala", "621654", "qwe@gmail.com"));
            listPersonsInCity.Add(new Person("Vijay", "Kamal", "143,ghj.", "9584235874", "Bangalore", "Karnataka", "635541", "bac@gmail.com"));

            Console.WriteLine("Find a Name of a Person in State Kerala");
            foreach (Person person in listPersonsInCity.FindAll(e => (e.State == "Kerala")).Take(1).ToList())
            {
                Console.WriteLine("Name : " + person.FirstName);
            }
        }
    }
}
