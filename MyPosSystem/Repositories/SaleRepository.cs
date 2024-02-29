using MyPosSystem.Interfaces;
using MyPosSystem.Models;
using MyPosSystem;

namespace MyPosSystem.Repositories;

public class SaleRepository : ReposityBase<Sale>, ISaleRepository
{
    public SaleRepository(DBContext ctx) : base(ctx)
    {
        
    }
}