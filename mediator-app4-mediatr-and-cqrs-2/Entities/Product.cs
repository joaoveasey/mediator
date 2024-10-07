namespace mediator_app4_mediatr_and_cqrs_2.Entities
{
    public class Product
    {
        public Product(string title, decimal description)
        {
            Title = title;
            Description = description;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Description { get; set; }
    }
}
