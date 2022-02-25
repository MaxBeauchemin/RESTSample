using DomainSample.DTOs.Customer;
using DomainSample.Services.Customer;
using System.Collections.Generic;
using System.Web.Http;

namespace RESTSample.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly CustomerService _customerService;

        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        // GET api/customer
        public IEnumerable<CustomerDto> Get()
        {
            return _customerService.GetAllCustomers();
        }

        // GET api/customer/5
        public CustomerDetailsDto GetById(int id)
        {
            return _customerService.GetCustomerDetailsById(id);
        }
    }
}
