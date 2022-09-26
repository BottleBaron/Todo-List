static class TaskCommands
{
    public static string help = "help";
    public static string toggleTask = "check";
    public static string removeTask = "remove";
    public static string addTask = "add";
    public static string displayTasks = "tasks";

    static string[] commands = new string[]
    {
        help,
        toggleTask,
        removeTask,
        addTask,
        displayTasks
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