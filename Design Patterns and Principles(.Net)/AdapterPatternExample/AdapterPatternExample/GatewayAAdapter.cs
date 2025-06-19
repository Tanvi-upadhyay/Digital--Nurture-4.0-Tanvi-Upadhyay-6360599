public class GatewayAAdapter : IPaymentGateway {
    private ThirdPartyGatewayA gatewayA = new ThirdPartyGatewayA();
    public void ProcessPayment(string amount) {
        gatewayA.MakePayment(amount);
    }
}