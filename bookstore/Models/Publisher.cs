namespace bookstore.Models
{
    public class Publisher
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<Book>? Books { get; set; }
    }
}
