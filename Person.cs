using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Больничная_аптека
{
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Person (string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;

        }
    }
}
