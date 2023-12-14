using Order.Application.Repository;

namespace Order.Infrastructure.Repository;

public class OrderRepository : IOrderRepository
{
    public Task SaveChangesAsync()
    {
        return Task.FromResult(1);
    }
}
