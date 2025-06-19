public interface IPaymentGateway {
    void ProcessPayment(string amount);
}