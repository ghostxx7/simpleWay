using MainStore.DomainModels.Item;
using Microsoft.EntityFrameworkCore;

namespace MainStore.BaseContext
{
    public class MainStoreContext : DbContext
    {
        public DbSet<Item> Items => Set<Item>();
        public MainStoreContext() => Database.EnsureCreated();
    }
}