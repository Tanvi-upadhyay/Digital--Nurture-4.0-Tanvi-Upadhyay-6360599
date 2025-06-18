public class Main {
    public static void main(String[] args) {
        StockMarket market = new StockMarket();
        Observer mobile = new MobileApp();
        Observer web = new WebApp();

        market.register(mobile);
        market.register(web);

        market.setPrice(150.0f);
        market.setPrice(155.5f);

        market.deregister(mobile);
        market.setPrice(160.0f);
    }
}