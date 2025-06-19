public class Main {
    public static void main(String[] args) {
        TaskLinkedList taskList = new TaskLinkedList();
        taskList.addTask(1, "Design UI", "Pending");
        taskList.addTask(2, "Setup Database", "In Progress");
        taskList.addTask(3, "Write API", "Pending");

        System.out.println("All Tasks:");
        taskList.traverseTasks();

        System.out.println("\nSearching for Task 2:");
        Task task = taskList.searchTask(2);
        System.out.println(task != null ? task : "Task not found.");

        System.out.println("\nDeleting Task 2...");
        taskList.deleteTask(2);

        System.out.println("\nTasks After Deletion:");
        taskList.traverseTasks();
    }
}