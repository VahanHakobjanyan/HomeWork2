namespace Pagination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class PaginationRequest
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public PaginationRequest(int pageSize, int pageNumber)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }

    public class PaginationResponse
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }

        public IEnumerable<Animal> animals = new List<Animal>();

        public PaginationResponse() { }
        public PaginationResponse(int pageNumber, int pageSize, int totalItems, int totalPages)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalItems = totalItems;
            TotalPages = totalItems;
        }
    }
}
