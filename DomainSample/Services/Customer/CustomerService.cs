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

        public CustomerDto CreateCustomer(CreateCustomerRequest request)
        {
            if (request == null) throw new ArgumentException("Null Request");

            var model = new Models.Customer
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                EmailAddress = request.EmailAddress,
                PhoneNumber = request.PhoneNumber
            };

            _context.Customers.Add(model);
            _context.SaveChanges();

            return new CustomerDto(model);
        }

        public CustomerDto UpdateCustomer(int id, UpdateCustomerRequest request)
        {
            var model = _context.Customers.Where(c => c.Id == id).FirstOrDefault();

            if (model == null) throw new ArgumentException("Customer Not Found");

            model.FirstName = request.FirstName;
            model.LastName = request.LastName;
            model.EmailAddress = request.EmailAddress;
            model.PhoneNumber = request.PhoneNumber;

            _context.SaveChanges();

            return new CustomerDto(model);
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
