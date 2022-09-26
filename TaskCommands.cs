static class TaskCommands
{
    public static string help = "help";
    public static string toggleTask = "check";
    public static string removeTask = "remove";
    public static string addTask = "add";
    public static string displayTasks = "list";
    public static string clear = "clear";
    public static string clearList = "clist";

    static string[] commands = new string[]
    {
        help + " - Displays all valid commands",
        toggleTask + " - Format: check <index> or <all> - Toggles the checkbox of the task with the corresponding index",
        removeTask + " - Format: remove <index> - Removes the task with the corresponding index",
        addTask + " Format: add <name> - Adds a task to your list",
        displayTasks + " - Shows all current tasks",
        clear + " - Clears the console",
        clearList + " - Clears your Todo List"
    };

    public static void DisplayCommands()
    {
        foreach (string command in commands)
        {
            Console.WriteLine(command);
        }
        Console.ReadKey();
    }
}