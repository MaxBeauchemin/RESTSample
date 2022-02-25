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
        public void GetAllCustomers()
        {
            var customers = _customerService.GetAllCustomers();

            Assert.AreEqual(2, customers.Count);
        }

        [TestMethod]
        public void GetCustomerByIdValid()
        {
            var customer = _customerService.GetCustomerDetailsById(1);

            Assert.AreEqual("Greg", customer.FirstName);
        }

        [TestMethod]
        public void GetCustomerByIdInvalid()
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
    }
}
