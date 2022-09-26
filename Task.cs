class Task
{
    public bool IsDone { get; set; }
    public string TaskName { get; set; }
    public char CheckMark { get; set; }
    public int TaskIndex { get; set; }

    public Task(string taskName, int taskIndex)
    {
        IsDone = false;
        this.TaskName = taskName;
        CheckMark = ' ';
        this.TaskIndex = taskIndex;
    }

    public void WriteTask()
    {
        Console.WriteLine($"{TaskIndex}). [{CheckMark}] {TaskName}");
    }

    public void ToggleIsDone()
    {
        IsDone = IsDone;

        if (IsDone)
            CheckMark = 'x';
        else
            CheckMark = ' ';
    }
}