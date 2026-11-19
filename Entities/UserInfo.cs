namespace EShopWeb.Entities;

public class UserInfo
{
    public string Name {get;set;} = string.Empty;
    public string Surname {get;set;} = string.Empty;
    public string? TelephoneNumber {get;set;}
    public DateTime? DateOfBirth {get;set;}
}