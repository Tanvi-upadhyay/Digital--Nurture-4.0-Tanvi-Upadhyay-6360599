using System;
class Program {
    static void Main(string[] args) {
        StockMarket stockMarket = new StockMarket();
        IObserver mobile = new MobileApp();
        IObserver web = new WebApp();
        stockMarket.Register(mobile);
        stockMarket.Register(web);
        stockMarket.SetPrice(120.5f);
        stockMarket.SetPrice(125.75f);
    }
}
