using Order.Domain.Events;
using Order.Domain.SeedWork;

namespace Order.Domain.AggregateModels.OrderModels;

public class Order : BaseEntity, IAggregateRoot
{
    //Order modellerin yönetileceği en tepedeki class bu'dur.Markup AggregateRoot ile işaretledik.
    public DateTime OrderDate { get; private set; }
    public string Description { get; private set; }
    public string UserName { get; private set; }
    public string OrderStatus { get; private set; }
    public Address Address { get; private set; }
    public ICollection<OrderItem> OrderItems { get; private set; }

    public Order(DateTime orderDate, string description, string userName, string orderStatus, Address address, ICollection<OrderItem> orderItems)
    {
        if (OrderDate < DateTime.UtcNow)
            throw new Exception("Orderdate must be greater than now.");

        if (Address.City is null)
            throw new ArgumentNullException("City cannot be null");
        OrderDate = orderDate;
        Description = description ?? throw new ArgumentNullException(nameof(description));
        UserName = userName;
        OrderStatus = orderStatus ?? throw new ArgumentNullException(nameof(orderStatus));
        Address = address ?? throw new ArgumentNullException(nameof(address));
        OrderItems = orderItems ?? throw new ArgumentNullException(nameof(orderItems));
        AddDomainEvent(new OrderStartedDomainEvent("userName",this));
    }

    public void AddOrderItem(int quantity, decimal price, int productId)
    {
        OrderItem orderItem=new (3,5,7);
        OrderItems.Add(orderItem);
    }
}
