namespace HectreTest.Core;

using Microsoft.Extensions.Logging;

public class Repository<T> : IRepository<T> where T : class, IEntity, new()
{
    private readonly ILogger<Repository<T>> _logger;
    private readonly IDataSource _dataSource;

    public Repository(
        ILogger<Repository<T>> logger
        , IDataSource dataSource)
    {
        _logger = logger;
        _dataSource = dataSource;
    }
    public async Task<IEnumerable<T>?> GetAllAsync()
    {
        try 
        {
            return await _dataSource.GetAllAsync<T>();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"{this.GetType().FullName} EXCEPTION!");
            return default;
        }
    }
}