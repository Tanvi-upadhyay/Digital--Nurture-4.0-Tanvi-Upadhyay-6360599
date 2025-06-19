using System;

class Program {
    static void Main(string[] args) {
        Product[] products = {
            new Product(1, "Apple", "Fruits"),
            new Product(2, "Banana", "Fruits"),
            new Product(3, "Carrot", "Vegetables")
        };

        Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

        int indexLinear = SearchAlgorithms.LinearSearch(products, "Banana");
        Console.WriteLine("Linear Search: Banana found at index " + indexLinear);

        int indexBinary = SearchAlgorithms.BinarySearch(products, "Banana");
        Console.WriteLine("Binary Search: Banana found at index " + indexBinary);
    }
}