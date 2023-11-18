using FactoryMethod.A.Models;

namespace FactoryMethod.A.Infra;
public class PaymentSlipService : IPaymentService
{
    public object Process(OrderModel model)
    {
        return "Dados do boleto";
    }
}
