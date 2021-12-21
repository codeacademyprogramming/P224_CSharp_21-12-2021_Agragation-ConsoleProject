using System;
using System.Collections.Generic;
using System.Text;

namespace AgregationProject
{
    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public byte Age { get; set; }
        public Address Address { get; set; }
        public Universitet Universitet { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"{Name} {SurName} {FatherName} {Age} {Address.Country} {Address.City} {Address.Street}";
        }

    }
}
