public class Main {
    public static void main(String[] args) {
        Product[] products = {
            new Product("P001", "Phone", "Electronics"),
            new Product("P002", "Shirt", "Apparel"),
            new Product("P003", "Laptop", "Electronics")
        };

        int index = SearchEngine.linearSearch(products, "Laptop");
        System.out.println("Found at index: " + index);
    }
}