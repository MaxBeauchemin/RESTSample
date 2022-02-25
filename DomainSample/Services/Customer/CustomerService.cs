using DomainSample.DTOs.Customer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DomainSample.Services.Customer
{
    public class CustomerService
    {
        private readonly DatabaseSampleContext _context;
        public CustomerService()
        {
            _context = new DatabaseSampleContext();
        }

        public List<CustomerDto> GetAllCustomers()
        {
            return _context.Customers.ToList().Select(c => new CustomerDto(c)).ToList();
        }

        public CustomerDetailsDto GetCustomerDetailsById(int id)
        {
            var model = _context.Customers.Where(c => c.Id == id).FirstOrDefault();

            if (model == null) throw new ArgumentException("Customer Not Found");

            return new CustomerDetailsDto(model);
        }
    }
}
