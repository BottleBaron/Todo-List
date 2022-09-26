internal class Program
{

    private static void Main(string[] args)
    {
        List<Task> taskList = new();

        Console.WriteLine("TodoList initiated. \nUse <h> or <help> to get a list of commands");

        while (true)
        {
            string userCommand = Console.ReadLine();

            // If the last element of the command is a digit
            // Split the array into two parts and place them into separated command
            List<string> separatedCommand = new();
            if (userCommand.Any())
                if (char.IsDigit(userCommand.Last()))
                {

                }

            // If input is correct command or that commands first letter
            if (userCommand == TaskCommands.help || userCommand == TaskCommands.help.First().ToString())
                TaskCommands.DisplayCommands();

            // TODO: Fix functionality to have more tasks than single digit numbers
            else if ( == TaskCommands.toggleTask || userCommand == TaskCommands.toggleTask.First().ToString())
            {
                if ()
                {
                    int commandIndex = Convert.ToInt32(userCommand.Last());

                    try
                    {
                        taskList[commandIndex].ToggleIsDone();
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Index was out of range. Use <t> or <tasks> to display current tasks.");
                    }
                }
            }
            else
                Console.WriteLine("Command not recognized. Use <h> or <help> for a list of commands");




        }
    }
}