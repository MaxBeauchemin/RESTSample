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

        // GET : /api/customer
        [HttpGet]
        public IEnumerable<CustomerDto> Get()
        {
            return _customerService.GetAllCustomers();
        }

        // GET : /api/customer/{id}
        [HttpGet]
        public CustomerDetailsDto GetById(int id)
        {
            return _customerService.GetCustomerDetailsById(id);
        }

        // POST : /api/customer
        [HttpPost]
        public CustomerDto CreateCustomer([FromBody]CreateCustomerRequest request)
        {
            return _customerService.CreateCustomer(request);
        }

        // PUT : /api/customer/{id}
        [HttpPut]
        public CustomerDto UpdateCustomer(int id, [FromBody]UpdateCustomerRequest request)
        {
            return _customerService.UpdateCustomer(id, request);
        }

        // DELETE : /api/customer/{id}
        [HttpDelete]
        public int DeleteCustomer(int id)
        {
            return _customerService.DeleteCustomerById(id);
        }

    }
}
