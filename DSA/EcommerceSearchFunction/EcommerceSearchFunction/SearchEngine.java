import java.util.Arrays;

public class SearchEngine {
    public static int linearSearch(Product[] products, String name) {
        for (int i = 0; i < products.length; i++) {
            if (products[i].getProductName().equals(name)) return i;
        }
        return -1;
    }

    public static int binarySearch(Product[] products, String name) {
        Arrays.sort(products, (a, b) -> a.getProductName().compareTo(b.getProductName()));
        int left = 0, right = products.length - 1;
        while (left <= right) {
            int mid = (left + right) / 2;
            int cmp = products[mid].getProductName().compareTo(name);
            if (cmp == 0) return mid;
            if (cmp < 0) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }
}