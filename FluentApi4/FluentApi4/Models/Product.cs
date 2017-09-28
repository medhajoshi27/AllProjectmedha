namespace FluentApi4.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public virtual Order Order { get; set; }
    }
}