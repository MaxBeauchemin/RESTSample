namespace DomainSample.DTOs.Product
{
    public class FindProductsRequest
    {
        //Filters
        public string Keyword { get; set; }

        //Pagination
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
