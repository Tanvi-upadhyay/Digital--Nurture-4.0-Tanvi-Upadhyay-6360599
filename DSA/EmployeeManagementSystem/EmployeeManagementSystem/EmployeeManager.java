public class EmployeeManager {
    private Employee[] employees = new Employee[100];
    private int count = 0;

    public void addEmployee(Employee emp) {
        if (count < employees.length) {
            employees[count++] = emp;
        }
    }

    public void deleteEmployee(String id) {
        for (int i = 0; i < count; i++) {
            if (employees[i].employeeId.equals(id)) {
                for (int j = i; j < count - 1; j++) {
                    employees[j] = employees[j + 1];
                }
                employees[--count] = null;
                return;
            }
        }
    }

    public void traverseEmployees() {
        for (int i = 0; i < count; i++) {
            System.out.println(employees[i].name + " - " + employees[i].position);
        }
    }

    public Employee searchEmployee(String id) {
        for (int i = 0; i < count; i++) {
            if (employees[i].employeeId.equals(id)) {
                return employees[i];
            }
        }
        return null;
    }
}