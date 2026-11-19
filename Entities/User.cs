using Microsoft.AspNetCore.SignalR;

namespace EShopWeb.Entities;

public class User
{
    public Guid Id {get;set;}
    public string Email {get;set;} = string.Empty;
    public string Password {get;set;} = string.Empty;
    public UserInfo UserInfo {get;set;} = new();
}