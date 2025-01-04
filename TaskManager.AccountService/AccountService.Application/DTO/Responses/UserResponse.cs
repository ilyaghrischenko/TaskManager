namespace AccountService.Application.DTO.Responses;

public class UserResponse(long id, string login, string password, string email)
{
    public long Id { get; set; } = id;
    public string Login { get; set; } = login;
    public string Password { get; set; } = password;
    public string Email { get; set; } = email;
}