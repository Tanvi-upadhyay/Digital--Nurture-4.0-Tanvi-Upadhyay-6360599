public class Main {
    public static void main(String[] args) {
        Image image1 = new ProxyImage("photo1.jpg");
        Image image2 = new ProxyImage("photo2.jpg");

        image1.display(); // loading + display
        image1.display(); // only display
        image2.display(); // loading + display
    }
}