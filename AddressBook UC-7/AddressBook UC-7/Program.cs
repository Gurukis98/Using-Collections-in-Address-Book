using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook_UC_7
{
   public class Person
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Person1 Name");
            List<string> name = new List<string>();
            name.Add(Console.ReadLine());
            Console.WriteLine("Enter the Person2 Name");
            name.Add(Console.ReadLine());
            Console.WriteLine("Enter the Person3 Name ");
            name.Add(Console.ReadLine());

            List<string> uniqueList = name.Distinct().ToList();
            uniqueList.ForEach(i => Console.WriteLine($"{i}"));

        }
    }
}
