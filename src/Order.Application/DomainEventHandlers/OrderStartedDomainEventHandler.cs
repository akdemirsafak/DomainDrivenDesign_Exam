using Order.Domain.Events;
using MediatR;
using Order.Application.Repository;
using Order.Domain.AggregateModels.BuyerModels;

namespace Order.Application.DomainEventHandlers;

public class OrderStartedDomainEventHandler : INotificationHandler<OrderStartedDomainEvent>
{
    private readonly IBuyerRepository _buyerRepository;

    public OrderStartedDomainEventHandler(IBuyerRepository buyerRepository)
    {
        _buyerRepository = buyerRepository;
    }

    public Task Handle(OrderStartedDomainEvent notification, CancellationToken cancellationToken)
    {
        if (notification.Order.UserName is null)
        {
            var buyer=new Buyer(notification.UserName);
            //_buyerRepository.Add(buyer); //Create new Buyer and get new Id
            //set order's buyerId
        }
        return Task.CompletedTask;
    }
}
