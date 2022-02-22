using System.Collections.Generic;
using System.Linq;

namespace DomainSample.Services.Customer
{
    public class CustomerService
    {
        public List<string> GetCustomerEmails()
        {
            var context = new DatabaseSampleContext();

            return context.Customers.Select(c => c.EmailAddress).ToList();
        }
    }
}
