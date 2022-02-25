using DomainSample.Services.Customer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestSample
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void TestGetAllCustomers()
        {
            var customerService = new CustomerService();

            var customers = customerService.GetAllCustomers();

            Assert.AreEqual(2, customers.Count);
        }
    }
}
