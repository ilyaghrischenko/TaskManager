using Shared.Data.Projections;

namespace AccountService.Data.Projections;

public class UserProjection(long id, string login, string password, string email) : BaseProjection(id)
{
    public string Login { get; set; } = login;
    public string Password { get; set; } = password;
    public string Email { get; set; } = email;
}