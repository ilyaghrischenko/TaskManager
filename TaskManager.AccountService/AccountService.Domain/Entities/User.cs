using SharedService.Domain.Entities;

namespace AccountService.Domain.Entities;

public class User : BaseEntity
{
    public string Login  { get; set; }
    public string Password  { get; set; }
    public string Email  { get; set; }

    public User() {}

    public User(string login, string password, string email)
    {
        Login = login;
        Password = password;
        Email = email;
    }
}