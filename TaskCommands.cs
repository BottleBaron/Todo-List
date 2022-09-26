static class TaskCommands
{
    public static string help = "help";
    public static string toggleTask = "check";
    public static string removeTask = "remove";
    public static string addTask = "add";
    public static string displayTasks = "tasks";
    public static string clear = "clear";

    static string[] commands = new string[]
    {
        help + " - Displays all valid commands",
        toggleTask + " Format: check <index> - Toggles the checkbox of the task with the corresponding index",
        removeTask + " Format: remove <index> - Removes the task with the corresponding index",
        addTask + " Format: add <name> - Adds a task to your list",
        displayTasks + " - Shows all current tasks",
        clear + " - Clears the console"
    };

    public static void DisplayCommands()
    {
        foreach (string command in commands)
        {
            Console.WriteLine(command);
        }

        Console.WriteLine("\n");
        Console.ReadKey();
    }
}