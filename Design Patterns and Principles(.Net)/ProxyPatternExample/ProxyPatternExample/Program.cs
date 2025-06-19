using System;
class Program {
    static void Main(string[] args) {
        Image image = new ProxyImage("test_image.jpg");
        image.Display();
        Console.WriteLine("Image will not be loaded again.");
        image.Display();
    }
}
