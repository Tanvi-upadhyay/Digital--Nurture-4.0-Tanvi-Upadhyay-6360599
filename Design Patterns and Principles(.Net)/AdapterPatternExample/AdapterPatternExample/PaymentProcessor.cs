public class PaymentProcessor {
    private IPaymentGateway _gateway;
    public PaymentProcessor(IPaymentGateway gateway) {
        _gateway = gateway;
    }
    public void Pay(string amount) {
        _gateway.ProcessPayment(amount);
    }
}