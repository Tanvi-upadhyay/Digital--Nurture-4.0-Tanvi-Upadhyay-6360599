using System;
public class WebApp : IObserver {
    public void Update(float price) {
        Console.WriteLine($"Web App: Stock price updated to {price}");
    }
}
