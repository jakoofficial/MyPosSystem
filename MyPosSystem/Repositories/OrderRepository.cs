using MyPosSystem.Interfaces;
using MyPosSystem.Models;
using MyPosSystem;

namespace MyPosSystem.Repositories;

public class OrderRepository : ReposityBase<Order>, IOrderRepository
{
    public OrderRepository(DBContext ctx) : base(ctx)
    {
        
    }
    
}