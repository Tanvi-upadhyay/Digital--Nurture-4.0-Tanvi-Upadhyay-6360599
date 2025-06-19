using System.Collections.Generic;
public class StockMarket : IStock {
    private List<IObserver> observers = new List<IObserver>();
    private float price;
    public void Register(IObserver observer) => observers.Add(observer);
    public void Deregister(IObserver observer) => observers.Remove(observer);
    public void Notify() {
        foreach (var observer in observers) {
            observer.Update(price);
        }
    }
    public void SetPrice(float newPrice) {
        price = newPrice;
        Notify();
    }
}