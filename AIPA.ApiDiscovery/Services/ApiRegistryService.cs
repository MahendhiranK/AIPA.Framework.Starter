using AIPA.ApiDiscovery.Models;

namespace AIPA.ApiDiscovery.Services;

public class ApiRegistryService
{
    private readonly List<ApiDescriptor> _registry = new();

    public void Register(ApiDescriptor descriptor)
    {
        _registry.Add(descriptor);
    }

    public List<ApiDescriptor> GetAll()
    {
        return _registry;
    }

    public ApiDescriptor? GetByName(string name)
    {
        return _registry.FirstOrDefault(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }
}
