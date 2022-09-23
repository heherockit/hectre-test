using Newtonsoft.Json;

namespace HectreTest.Core;

public class JsonDataSource : IDataSource
{
    public async Task<IEnumerable<T>?> GetAllAsync<T>() where T: class, IEntity, new()
    {
        var str = await File.ReadAllTextAsync("data.json");
        
        if (string.IsNullOrEmpty(str))
        {
            return default;
        }
        
        return JsonConvert.DeserializeObject<IEnumerable<T>>(str);
    }
}