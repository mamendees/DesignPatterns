using FactoryMethod.A.Models;

namespace FactoryMethod.A.Infra;
public class CreditCardService : IPaymentService
{
    public object Process(OrderModel model)
    {
        return "Dados Cartão";
    }
}
