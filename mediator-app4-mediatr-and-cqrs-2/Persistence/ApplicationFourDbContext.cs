using mediator_app4_mediatr_and_cqrs_2.Entities;

namespace mediator_app4_mediatr_and_cqrs_2.Persistence
{
    public class ApplicationFourDbContext
    {
        public ApplicationFourDbContext()
        {
            Products = new List<Product>();
        }

        public List<Product> Products { get; set; }
    }
}