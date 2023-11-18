using FactoryMethod.A.Infra;
using FactoryMethod.A.Models;

namespace FactoryMethod.A.Factory;
public class PaymentServiceFactory : IPaymentServiceFactory
{
    private readonly CreditCardService _creditCardService;
    private readonly PaymentSlipService _paymentSlipService;

    public PaymentServiceFactory(
        CreditCardService creditCardService,
        PaymentSlipService paymentSlipService
    )
    {
        _creditCardService = creditCardService;
        _paymentSlipService = paymentSlipService;
    }
    
    public IPaymentService GetService(Payment payment)
    {
        IPaymentService paymentService = payment switch
        {
            Payment.CreditCard => _creditCardService,
            Payment.PaymentSlip => _paymentSlipService,
            _ => throw new InvalidOperationException("Error")
        };

        return paymentService;
    }
}
