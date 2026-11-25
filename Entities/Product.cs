namespace EShopWeb.Entities;

public class Product
{
    public Guid Id {get;set;}
    public string Name {get;set;} = string.Empty;
    public decimal Price {get;set;}
    public Guid ProducerId {get;set;}
    public Producer Producer {get;set;} = null!;
    public Guid CategoryId {get;set;}
    public Category Category {get;set;} = null!;
    public ICollection<Tag> Tags {get;set;} = new List<Tag>();
}