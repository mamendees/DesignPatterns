using FactoryMethod.A.Models;

namespace FactoryMethod.A.Infra;
public interface IPaymentService
{
    object Process(OrderModel model);
}
