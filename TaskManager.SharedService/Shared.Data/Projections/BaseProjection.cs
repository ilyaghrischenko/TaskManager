namespace Shared.Data.Projections;

public abstract class BaseProjection(long id)
{
    public long Id { get; set; } = id;
}