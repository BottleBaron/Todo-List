internal class Program
{

    private static void Main(string[] args)
    {
        List<Task> taskList = new();

        Console.WriteLine("TodoList initiated. \nUse <help> to get a list of commands");

        while (true)
        {
            string userCommand = Console.ReadLine();

            // If the last element of the command is a digit
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
                        taskList[commandIndex].ToggleIsDone();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Index was out of range. Use <tasks> to display current tasks.");
                    }
                }
            }
            else if(separatedCommand[0] == TaskCommands.addTask)
            {
                Task task = new(separatedCommand[1], taskList.Count);

                taskList.Add(task);
            }
            else if(separatedCommand[0] == TaskCommands.removeTask)
            {
                if(char.IsDigit(userCommand.Last()))
                {
                    int commandIndex = Convert.ToInt32(separatedCommand[1]);

                    try
                    {
                        taskList[commandIndex] = null;
                        taskList.Remove(taskList[commandIndex]);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Index was out of range. Use <tasks> to display current tasks.");
                    }
                }
            }
            else if(separatedCommand[0] == TaskCommands.displayTasks)
            {
                foreach (Task item in taskList)
                {
                    item.WriteTask();
                }
            }
            else if(separatedCommand[0] == TaskCommands.clear)
            {
                Console.Clear();
            }
            else if(string.IsNullOrEmpty(separatedCommand[0]))
            {
                // Do Nothing
            }
            else
            {
                Console.WriteLine("Command not recognized. Use <h> or <help> for a list of commands");
            }

        }
    }
}
