using AccountService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccountService.Data;

public class UsersContext : DbContext
{
    public UsersContext() { }
    
    public UsersContext(DbContextOptions<UsersContext> options)
        : base(options) { }
    
    public virtual DbSet<User> Users { get; set; }
}