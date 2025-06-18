public class TestLibrary {
    public static void main(String[] args) {
        Library lib = new Library();
        lib.addBook(new Book(1, "Java Programming", "Tanvi"));
        lib.addBook(new Book(2, "Python Basics", "Amit"));
        lib.addBook(new Book(3, "C++ Concepts", "Ravi"));

        System.out.println("Searching 'Python Basics' with Linear Search:");
        Book foundLinear = lib.linearSearch("Python Basics");
        if (foundLinear != null)
            System.out.println("Found: " + foundLinear.title + " by " + foundLinear.author);
        else
            System.out.println("Not Found");

        System.out.println("Searching 'Python Basics' with Binary Search:");
        Book foundBinary = lib.binarySearch("Python Basics");
        if (foundBinary != null)
            System.out.println("Found: " + foundBinary.title + " by " + foundBinary.author);
        else
            System.out.println("Not Found");
    }
}
