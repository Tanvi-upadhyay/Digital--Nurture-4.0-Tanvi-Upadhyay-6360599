public class Main {
    public static void main(String[] args) {
        InventoryManager manager = new InventoryManager();
        Product p1 = new Product("P001", "Laptop", 10, 75000);
        manager.addProduct(p1);
        System.out.println("Product added: " + p1.getProductId());
    }
}