namespace HectreTest.Core;

public interface IDataSource
{
    Task<IEnumerable<T>?> GetAllAsync<T>() where T: class, IEntity, new();
}