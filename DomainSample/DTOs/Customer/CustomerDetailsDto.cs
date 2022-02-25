namespace DomainSample.DTOs.Customer
{
    public class CustomerDetailsDto
    {
        public CustomerDetailsDto(Models.Customer c)
        {
            this.Id = c.Id;
            this.FirstName = c.FirstName;
            this.LastName = c.LastName;
            this.EmailAddress = c.EmailAddress;
            this.PhoneNumber = c.PhoneNumber;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
