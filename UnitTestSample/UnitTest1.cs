using DomainSample.Services.Customer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestSample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var customerService = new CustomerService();

            var emails = customerService.GetCustomerEmails();

            Assert.AreEqual(1, emails.Count);
        }
    }
}
