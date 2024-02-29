using MyPosSystem.Repositories;

namespace MyPosSystem.Interfaces;

public interface IRepositoryWrapper
{
    IOrderRepository Order { get; }
    IProductRepository Product { get; }
    ISaleRepository Sale { get; }
    IItemRepository Item { get; }

    void Save();
}