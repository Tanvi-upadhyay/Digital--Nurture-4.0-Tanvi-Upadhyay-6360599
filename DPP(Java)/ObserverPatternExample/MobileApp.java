public class MobileApp implements Observer {
    public void update(float price) {
        System.out.println("Mobile App - New stock price: " + price);
    }
}