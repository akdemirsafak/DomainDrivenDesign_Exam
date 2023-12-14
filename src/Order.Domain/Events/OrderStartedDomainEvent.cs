﻿using MediatR;

namespace Order.Domain.Events;

public class OrderStartedDomainEvent:INotification
{
    //Order'ın başladığını Buyer veya diğer bounded context'lere haber vereceğimiz eventler olacaktır.

    public string UserName { get; set; }
    public AggregateModels.OrderModels.Order Order { get; set; }

    public OrderStartedDomainEvent(string userName, AggregateModels.OrderModels.Order order)
    {
        UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        Order = order ?? throw new ArgumentNullException(nameof(order));
    }
}