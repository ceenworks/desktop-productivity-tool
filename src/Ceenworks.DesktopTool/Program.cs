using Ceenworks.DesktopTool;

var tasks = new[]
{
    new TaskItem("Prepare proposal", "open"),
    new TaskItem("Build demo", "in-progress"),
    new TaskItem("Send handoff notes", "done")
};

var report = TaskReport.From(tasks);

Console.WriteLine("Ceenworks Desktop Productivity Tool");
Console.WriteLine($"Total: {report.Total}");
Console.WriteLine($"Open: {report.Open}");
Console.WriteLine($"In progress: {report.InProgress}");
Console.WriteLine($"Done: {report.Done}");
