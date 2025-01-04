using Shared.Data.Projections;

namespace Shared.Domain.Interfaces.Repositories;

public interface IRepository<TProjection>
    where TProjection : BaseProjection
{
    Task<TProjection?> GetByIdAsync(long id);
    Task<TProjection?> GetByIdAsNoTrackingAsync(long id);
    Task<IEnumerable<TProjection>?> GetAllAsync();
    
    Task AddAsync(TProjection projection);
    Task UpdateAsync(TProjection projection, Action updateAction);
    Task DeleteAsync(TProjection projection);
}