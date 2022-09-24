using BlazeRP.CoreBusiness;
using BlazeRP.UseCases.PluginInterfaces;

namespace BlazeRP.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        public Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}