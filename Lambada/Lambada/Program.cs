using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambada");
            // UC1 Creating list of preson And inserting Details
            System.Collections.Generic.List<Person> listpersondetails = new List<Person>();
            Insert(listpersondetails);
            Console.WriteLine(listpersondetails);
            Get_person_Age_Below_60(listpersondetails);
        }
        private static void Insert(List<Person> listpersondetails)
        {
            listpersondetails.Add(new Person("65464646", "Ravi", "47 Ward main road hyderabad", 34));
            listpersondetails.Add(new Person("65454134", "Raju", "57 ward rr complex nellore", 28));
            listpersondetails.Add(new Person("54666955", "Rakesh", "main road nampalli hyderabad", 45));
            listpersondetails.Add(new Person("55211255", "Anvash", "62 Ward Balaji Nagar Nellore", 61));
            listpersondetails.Add(new Person("5212515", "Raja", "jj paradise gudur 2 ward", 62));
           

        }
        // UC2 get person Age Below 60
        private static void Get_person_Age_Below_60(List<Person> listpersondetails)
        {
            foreach(Person person in listpersondetails.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + person.Name + " \t\tAge: " + person.Age);
            }

        }
    }
}
