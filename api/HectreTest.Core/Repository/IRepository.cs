namespace HectreTest.Core;

public interface IRepository<T> where T: class, IEntity, new()
{
    Task<IEnumerable<T>?> GetAllAsync();
}