﻿namespace Order.Domain.SeedWork;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
}
