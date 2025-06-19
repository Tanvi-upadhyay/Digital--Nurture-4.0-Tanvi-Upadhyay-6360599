public class Main {
    public static void main(String[] args) {
        Order[] orders = {
            new Order("O001", "Alice", 1500.0),
            new Order("O002", "Bob", 900.0),
            new Order("O003", "Charlie", 1200.0)
        };

        Sorter.quickSort(orders, 0, orders.length - 1);

        for (Order o : orders) {
            System.out.println(o.orderId + " - " + o.totalPrice);
        }
    }
}