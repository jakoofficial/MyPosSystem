using MyPosSystem.Interfaces;
using MyPosSystem.Models;
using MyPosSystem;

namespace MyPosSystem.Repositories;

public class ProductRepository : ReposityBase<Product>, IProductRepository
{
    public ProductRepository(DBContext ctx) : base(ctx)
    {
        
    }
}