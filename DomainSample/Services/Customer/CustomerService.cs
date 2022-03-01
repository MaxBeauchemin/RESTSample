using DomainSample.DTOs.Customer;
using DomainSample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DomainSample.Services.Customer
{
    public class CustomerService : BaseService
    {
        private readonly LogArea _logArea = LogArea.Customer;

        public CustomerDto CreateCustomer(CreateCustomerRequest request)
        {
            try
            {
                EntryLog(_logArea, request);

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
            catch (Exception ex)
            {
                ErrorLog(_logArea, ex);
                throw ex;
            }
        }

        public CustomerDto UpdateCustomer(int id, UpdateCustomerRequest request)
        {
            try
            {
                EntryLog(_logArea, request);

                var model = _context.Customers.Where(c => c.Id == id).FirstOrDefault();

                if (model == null) throw new ArgumentException("Customer Not Found");

                model.FirstName = request.FirstName;
                model.LastName = request.LastName;
                model.EmailAddress = request.EmailAddress;
                model.PhoneNumber = request.PhoneNumber;

                _context.SaveChanges();

                return new CustomerDto(model);
            }
            catch (Exception ex)
            {
                ErrorLog(_logArea, ex);
                throw ex;
            }
        }

        public int DeleteCustomerById(int id)
        {
            try
            {
                EntryLog(_logArea, id);

                var model = _context.Customers.Where(c => c.Id == id).FirstOrDefault();

                if (model == null) throw new ArgumentException("Customer Not Found");

                _context.Customers.Remove(model);

                _context.SaveChanges();

                return id;
            }
            catch (Exception ex)
            {
                ErrorLog(_logArea, ex);
                throw ex;
            }
        }

        public List<CustomerDto> GetAllCustomers()
        {
            try
            {
                return _context.Customers.ToList().Select(c => new CustomerDto(c)).ToList();
            }
            catch (Exception ex)
            {
                ErrorLog(_logArea, ex);
                throw ex;
            }
        }

        public CustomerDetailsDto GetCustomerDetailsById(int id)
        {
            try
            {
                var model = _context.Customers.Where(c => c.Id == id).FirstOrDefault();

                if (model == null) throw new ArgumentException("Customer Not Found");

                return new CustomerDetailsDto(model);
            }
            catch (Exception ex)
            {
                ErrorLog(_logArea, ex);
                throw ex;
            }
        }
    }
}
