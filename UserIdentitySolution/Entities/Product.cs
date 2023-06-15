namespace UserIdentitySolution.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }

    public decimal Price { get; set; }
    public string Image { get; set; }
    public DateTime CreatedDate { get; set; }

}
