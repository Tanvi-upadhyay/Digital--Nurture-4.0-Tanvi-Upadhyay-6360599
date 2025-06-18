import java.util.*;

public class Library {
    List<Book> books = new ArrayList<>();

    public void addBook(Book book) {
        books.add(book);
    }

    public Book linearSearch(String title) {
        for (Book b : books) {
            if (b.title.equalsIgnoreCase(title)) {
                return b;
            }
        }
        return null;
    }

    public Book binarySearch(String title) {
        books.sort(Comparator.comparing(b -> b.title));
        int left = 0, right = books.size() - 1;

        while (left <= right) {
            int mid = (left + right) / 2;
            Book b = books.get(mid);
            int cmp = b.title.compareToIgnoreCase(title);
            if (cmp == 0) return b;
            else if (cmp < 0) left = mid + 1;
            else right = mid - 1;
        }
        return null;
    }
}
