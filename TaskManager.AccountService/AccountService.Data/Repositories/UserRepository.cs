using AccountService.Data.Projections;
using Microsoft.EntityFrameworkCore;
using Shared.Domain.Interfaces.Repositories;

namespace AccountService.Data.Repositories;

public class UserRepository(IDbContextFactory<UsersContext> contextFactory) : IRepository<UserProjection>
{
    private readonly IDbContextFactory<UsersContext> _contextFactory = contextFactory;
    
    public async Task<UserProjection?> GetByIdAsync(long id)
    {
        using var context = await _contextFactory.CreateDbContextAsync();

        return await context
            .Users
            .Select(user => new UserProjection(
                user.Id,
                user.Login,
                user.Password,
                user.Email))
            .FirstOrDefaultAsync(user => user.Id == id);
    }

    public async Task<UserProjection?> GetByIdAsNoTrackingAsync(long id)
    {
        using var context = await _contextFactory.CreateDbContextAsync();

        return await context
            .Users
            .AsNoTracking()
            .Select(user => new UserProjection(
                user.Id,
                user.Login,
                user.Password,
                user.Email))
            .FirstOrDefaultAsync(user => user.Id == id);
    }

    public async Task<IEnumerable<UserProjection>?> GetAllAsync()
    {
        using var context = await _contextFactory.CreateDbContextAsync();

        return await context
            .Users
            .AsNoTracking()
            .Select(user => new UserProjection(
                user.Id,
                user.Login,
                user.Password,
                user.Email))
            .ToListAsync();
    }

    public Task AddAsync(UserProjection projection)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UserProjection projection, Action updateAction)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(UserProjection projection)
    {
        throw new NotImplementedException();
    }
}