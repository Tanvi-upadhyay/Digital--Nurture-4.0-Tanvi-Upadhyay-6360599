public class Main {
    public static void main(String[] args) {
        EmployeeManager manager = new EmployeeManager();
        manager.addEmployee(new Employee("E001", "John", "Developer", 60000));
        manager.addEmployee(new Employee("E002", "Jane", "Manager", 75000));
        manager.traverseEmployees();
    }
}