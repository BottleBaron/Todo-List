internal class Program
{

    private static void Main(string[] args)
    {
        List<Task> taskList = new();

        Console.WriteLine("TodoList initiated. \nUse <help> to get a list of commands");

        while (true)
        {
            string userCommand = Console.ReadLine();

            
            // Split the array into two parts and place them into separated command
            string[] separatedCommand = new string[1];
            if (userCommand.Any(Char.IsWhiteSpace))
            {
                separatedCommand = userCommand.Split(' ', 2);
            }
            else
            {
                separatedCommand[0] = userCommand.ToLower();
            }

            // Checks for a valid command and executes their function
            if (separatedCommand[0] == TaskCommands.help)
            {
                TaskCommands.DisplayCommands();
            }
            else if (separatedCommand[0] == TaskCommands.toggleTask)
            {
                if (char.IsDigit(userCommand.Last()))
                {
                    int commandIndex = Convert.ToInt32(separatedCommand[1]);

                    try
                    {
                        taskList[commandIndex - 1].ToggleIsDone();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Index was out of range. Use <list> to display current tasks.");
                    }
                }
                else if(separatedCommand[1] == "all")
                {
                    foreach (Task entry in taskList)
                    {
                        entry.ToggleIsDone();
                    }
                }
            }
            else if(separatedCommand[0] == TaskCommands.addTask)
            {
                Task task = new(separatedCommand[1], taskList.Count + 1);

                taskList.Add(task);
            }
            else if(separatedCommand[0] == TaskCommands.removeTask)
            {
                if(char.IsDigit(userCommand.Last()))
                {
                    int commandIndex = Convert.ToInt32(separatedCommand[1]);

                    try
                    {
                        taskList[commandIndex - 1] = null;
                        taskList.Remove(taskList[commandIndex - 1]);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Index was out of range. Use <list> to display current tasks.");
                    }
                }
                else
                    Console.WriteLine("The last member of this command must be a number. Use <list> to display current tasks.");
            }
            else if(separatedCommand[0] == TaskCommands.displayTasks)
            {
                if(taskList.Count == 0)
                    Console.WriteLine("List is Empty");
                else
                {
                    foreach (Task entry in taskList)
                    {
                        entry.WriteTask();
                    }
                }
            }
            else if(separatedCommand[0] == TaskCommands.clear)
            {
                Console.Clear();
            }
            else if(separatedCommand[0] == TaskCommands.clearList)
            {
                taskList.Clear();
            }
            else if(string.IsNullOrEmpty(separatedCommand[0]))
            {
                // Do Nothing
            }
            else
            {
                Console.WriteLine("Command not recognized. Use or <list> for a list of commands");
            }

        }
    }
}
