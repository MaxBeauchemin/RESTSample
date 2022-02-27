using DomainSample.DTOs.Customer;
using DomainSample.Services.Customer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestSample
{
    [TestClass]
    public class CustomerTests
    {
        private readonly CustomerService _customerService;

        public CustomerTests()
        {
            _customerService = new CustomerService();
        }

        [TestMethod]
        public void A_CreateCustomer()
        {
            var customer = _customerService.CreateCustomer(new CreateCustomerRequest
            {
                FirstName = "Harry",
                LastName = "Potter"
            });

            var retrievedCustomer = _customerService.GetCustomerDetailsById(customer.Id);

            Assert.IsNotNull(retrievedCustomer);
            Assert.AreEqual(customer.Id, retrievedCustomer.Id);
            Assert.AreEqual(customer.FirstName, retrievedCustomer.FirstName);
            Assert.AreEqual(customer.LastName, retrievedCustomer.LastName);
            Assert.AreEqual(customer.EmailAddress, retrievedCustomer.EmailAddress);
            Assert.AreEqual(customer.PhoneNumber, retrievedCustomer.PhoneNumber);
        }

        [TestMethod]
        public void B_UpdateCustomer()
        {
            var customer = _customerService.CreateCustomer(new CreateCustomerRequest
            {
                FirstName = "Hermione",
                LastName = "Grainger"
            });

            var updatedCustomer = _customerService.UpdateCustomer(customer.Id, new UpdateCustomerRequest
            {
                FirstName = "Ron",
                LastName = "Weasley",
                EmailAddress = "r.w@hogwarts.edu",
                PhoneNumber = "(576) 555-8327"
            });

            var retrievedCustomer = _customerService.GetCustomerDetailsById(updatedCustomer.Id);

            Assert.IsNotNull(retrievedCustomer);
            Assert.AreEqual(updatedCustomer.Id, retrievedCustomer.Id);
            Assert.AreEqual(updatedCustomer.FirstName, retrievedCustomer.FirstName);
            Assert.AreEqual(updatedCustomer.LastName, retrievedCustomer.LastName);
            Assert.AreEqual(updatedCustomer.EmailAddress, retrievedCustomer.EmailAddress);
            Assert.AreEqual(updatedCustomer.PhoneNumber, retrievedCustomer.PhoneNumber);
        }

        [TestMethod]
        public void C_GetAllCustomers()
        {
            var customers = _customerService.GetAllCustomers();

            Assert.AreEqual(4, customers.Count);
        }

        [TestMethod]
        public void D_GetCustomerByIdValid()
        {
            var customer = _customerService.GetCustomerDetailsById(1);

            Assert.AreEqual("Greg", customer.FirstName);
        }

        [TestMethod]
        public void E_GetCustomerByIdInvalid()
        {
            var failed = false;

            try
            {
                var customer = _customerService.GetCustomerDetailsById(1000000);
            }
            catch
            {
                failed = true;
            }

            Assert.IsTrue(failed, "Expected to Fail");
        }

        [TestMethod]
        public void F_DeleteCustomer()
        {
            var customer = _customerService.CreateCustomer(new CreateCustomerRequest
            {
                FirstName = "Temp",
                LastName = "User"
            });

            var deletedId = _customerService.DeleteCustomerById(customer.Id);

            var failed = false;

            try
            {
                var retrievedCustomer = _customerService.GetCustomerDetailsById(deletedId);
            }
            catch
            {
                failed = true;
            }

            Assert.IsTrue(failed, "Expected to Fail");
        }
    }
}
