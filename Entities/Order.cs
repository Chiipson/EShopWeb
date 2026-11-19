using EShopWeb.Enums;

namespace EShopWeb.Entities;

public class Order
{
    public Guid Id {get;set;}
    public decimal Price {get;set;}
    public DateTime PlaceOrderDate {get;set;}
    public OrderStatus OrderStatus {get;set;}
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;
    public ICollection<OrderItem> OrderItems {get;set;} = new List<OrderItem>();
}