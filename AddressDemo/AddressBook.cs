using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressDemo
{
     class AddressBook
    {
        List<Address> addresses;

        public AddressBook()
        {
            addresses = new List<Address>();
        }

        public bool add(string firstName, string lastName, string address, string phoneNumber, string city, string state, string zipCode, string emailId)
        {
            Address addr = new Address(firstName, lastName, address, phoneNumber, city, state, zipCode, emailId);
            Address result = find(firstName);

            if (result == null)
            {
                addresses.Add(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool remove(string firstName)
        {
            Address addr = find(firstName);

            if (addr != null)
            {
                addresses.Remove(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
          public bool isEmpty()
          {
            return (addresses.Count == 0);
          }


          public Address find(string firstName)
          {
           Address addr = addresses.Find((a) => a.firstName == firstName);
           return addr;
          }
    }
}

