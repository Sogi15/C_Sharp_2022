using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practice
{
    class Person
    {
        private string name, phoneNumber, emailAddress;

        public Person(string name, string phonenNumber, string emailAddress)
        {
            this.name = name;
            this.phoneNumber = phonenNumber;
            this.emailAddress = emailAddress;
        }
        
        public void data()
        {
                Console.WriteLine($"Név: {this.name}, Telefon: {this.phoneNumber}, E-mail: {this.emailAddress}");
        }

    }
}
