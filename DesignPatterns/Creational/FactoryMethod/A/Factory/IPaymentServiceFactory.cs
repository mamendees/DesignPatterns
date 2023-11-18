using FactoryMethod.A.Infra;
using FactoryMethod.A.Models;


namespace FactoryMethod.A.Factory;
public interface IPaymentServiceFactory
{
    IPaymentService GetService(Payment payment);
}
