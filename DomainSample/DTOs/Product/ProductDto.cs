namespace DomainSample.DTOs.Product
{
    public class ProductDto
    {
        public ProductDto(Models.Product p)
        {
            this.Id = p.Id;
            this.Description = p.Description;
            this.CurrentPrice = p.CurrentPrice;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal CurrentPrice { get; set; }
    }
}
