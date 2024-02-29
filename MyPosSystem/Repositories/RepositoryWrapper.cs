using MyPosSystem;
using MyPosSystem.Interfaces;
using MyPosSystem.Repositories;

namespace MyPosSystem.Repositories;

public class RepositoryWrapper : IRepositoryWrapper
{
    private DBContext _dbContext;
    private IOrderRepository _order;
    private IProductRepository _product;
    private ISaleRepository _sale;
    private IItemRepository _item;

    public IOrderRepository Order
    {
        get
        {
            if (_order == null)
            {
                _order = new OrderRepository(_dbContext);
            }
            return _order;
        }
    }
    public IProductRepository Product
    {
        get
        {
            if (_product == null)
            {
                _product = new ProductRepository(_dbContext);
            }
            return _product;
        }
    }
    public ISaleRepository Sale
    {
        get
        {
            if (_sale == null)
            {
                _sale = new SaleRepository(_dbContext);
            }
            return _sale;
        }
    }
    public IItemRepository Item
    {
        get
        {
            if (_item == null)
            {
                _item = new ItemRepository(_dbContext);
            }
            return _item;
        }
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }
}