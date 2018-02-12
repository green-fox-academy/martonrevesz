using GoogleAPIDemo.Entities;
using GoogleAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleAPIDemo.Repositories
{
    public class AddressRepository
    {
        public AddressRepository(AddressContext addressContext)
        {
            AddressContext = addressContext;
        }

        public AddressContext AddressContext{ get; set; }

        public void AddAddress(Address address)
        {
            AddressContext.Addresses.Add(address);
            AddressContext.SaveChanges();
        }

        public Address GetAddress(long id)
        {
            return AddressContext.Addresses.FirstOrDefault(a => a.Id == id);
        }
    }
}
