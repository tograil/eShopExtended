namespace eShop.Ordering.Domain.AggregatesModel.OrderAggregate;

public interface IOrderAggregateFactory
{
    Order Create(string userId, string userName, Address address, int cardTypeId, string cardNumber, string cardSecurityNumber,
        string cardHolderName, DateTime cardExpiration, int? buyerId = null, int? paymentMethodId = null);
}
