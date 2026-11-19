namespace EShopWeb.Entities;

public class Producer
{
    public Guid Id {get;set;}
    public string Name {get;set;} = string.Empty;
    public ICollection<Product> Products = new List<Product>();
}