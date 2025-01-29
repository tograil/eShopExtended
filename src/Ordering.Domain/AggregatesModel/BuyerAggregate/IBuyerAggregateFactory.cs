namespace eShop.Ordering.Domain.AggregatesModel.BuyerAggregate;

public interface IBuyerAggregateFactory
{
    Buyer Create(string identity, string name);
}
