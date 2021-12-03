using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressDemo
{
    class Address
    {
        public string firstName;
        public string lastName;
        public string address;
        public string phoneNumber;
        public string city;
        public string state;
        public string zipCode;
        public string emailId;

        public Address(string firstName, string lastName, string address, string phoneNumber, string city, string state, string zipCode, string emailId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.emailId = emailId;

        }
    }
}
