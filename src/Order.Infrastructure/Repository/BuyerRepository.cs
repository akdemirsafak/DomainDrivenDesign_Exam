using Order.Application.Repository;

namespace Order.Infrastructure.Repository;

public class buyerRepository : IBuyerRepository
{
    public Task SaveChangesAsync()
    {
        return Task.FromResult(1);
    }
}
