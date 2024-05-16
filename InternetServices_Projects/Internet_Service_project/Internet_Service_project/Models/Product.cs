namespace Internet_Service_project.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

        public int Quantity { get; set; }
    }
}
