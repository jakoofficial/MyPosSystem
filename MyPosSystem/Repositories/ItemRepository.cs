using MyPosSystem.Interfaces;
using MyPosSystem;
using MyPosSystem.Models;
using MyPosSystem.Repositories;

namespace MyPosSystem.Repositories;

public class ItemRepository : ReposityBase<Item>, IItemRepository
{
    public ItemRepository(DBContext ctx) : base(ctx)
    {
        
    }
}