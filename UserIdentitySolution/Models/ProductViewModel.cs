namespace UserIdentitySolution.Models;

public class ProductViewModel
{
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }

    public decimal Price { get; set; }
    public DateTime CreatedDate { get; set; }
    public IFormFile Image { get; set; }
}
