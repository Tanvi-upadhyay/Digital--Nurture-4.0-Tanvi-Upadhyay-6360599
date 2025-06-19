public class Main {
    public static void main(String[] args) {
        PaymentContext context = new PaymentContext();

        context.setPaymentStrategy(new CreditCardPayment());
        context.pay();

        context.setPaymentStrategy(new PayPalPayment());
        context.pay();
    }
}