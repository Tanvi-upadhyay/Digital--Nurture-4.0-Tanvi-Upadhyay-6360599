using System;
public class MobileApp : IObserver {

    public void Update(float price) {
        Console.WriteLine($"Mobile App: Stock price updated to {price}");
    }
}
