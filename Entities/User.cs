using Microsoft.AspNetCore.SignalR;

namespace EShopWeb.Entities;

public class User
{
    public Guid Id {get;set;}
    public string Email {get;set;} = string.Empty;
    public string PasswordHash {get;set;} = string.Empty;
    public UserInfo UserInfo {get;set;} = new();
    public ICollection<Order> Orders {get;set;} = new List<Order>();
    public ICollection<Cart> Carts {get;set;} = new List<Cart>();
}