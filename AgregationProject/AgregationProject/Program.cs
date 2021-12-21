using System;

namespace AgregationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Filankes";
            string surname = "Filankesov";

            Person person = new Person();
            person.Name = name;
            person.SurName = "Baxshaliyev";
            person.FatherName = "Sukur";
            person.Age = 35;


            


            Address address = new Address();
            address.Country = "Azerbaijan";
            address.City = "Baki";
            address.Street = "28 may";

            person.Address = address;

            Console.WriteLine(person);
        }
    }
}
