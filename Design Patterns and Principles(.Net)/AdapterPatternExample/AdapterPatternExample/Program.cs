class Program {
    static void Main(string[] args) {
        IPaymentGateway gateway = new GatewayAAdapter();
        PaymentProcessor processor = new PaymentProcessor(gateway);
        processor.Pay("1000");
    }
}