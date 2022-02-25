using DomainSample.Services.Customer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestSample
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void TestGetCustomerEmails()
        {
            var customerService = new CustomerService();

            var emails = customerService.GetCustomerEmails();

            Assert.AreEqual(1, emails.Count);
        }
    }
}
