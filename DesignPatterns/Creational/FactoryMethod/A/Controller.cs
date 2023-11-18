using FactoryMethod.A.Factory;
using FactoryMethod.A.Models;

namespace FactoryMethod.A;
public class Controller
{
    private readonly IPaymentServiceFactory _paymentServiceFactory;
    
    public Controller(IPaymentServiceFactory paymentServiceFactory)
    {
        _paymentServiceFactory = paymentServiceFactory;
    }

    public string Post(OrderModel orderModel)
    {
        var paymentService = _paymentServiceFactory.GetService(orderModel.Payment);
        paymentService.Process(orderModel);
        return "Success";
    }
}
