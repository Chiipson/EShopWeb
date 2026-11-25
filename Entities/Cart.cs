using EShopWeb.Enums;

namespace EShopWeb.Entities;

public class Cart
{
    public Guid Id {get;set;}
    public CartStatus CartStatus {get;set;}
    public Guid UserId {get;set;}
    public User User {get;set;} = null!;
    public ICollection<CartItem> CartItems {get;set;} = new List<CartItem>();
}