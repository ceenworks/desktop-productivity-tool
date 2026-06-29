namespace Ceenworks.DesktopTool;

public record TaskItem(string Title, string Status);

public record TaskReport(int Total, int Open, int InProgress, int Done)
{
    public static TaskReport From(IEnumerable<TaskItem> tasks)
    {
        var list = tasks.ToList();

        return new TaskReport(
            list.Count,
            list.Count(task => task.Status == "open"),
            list.Count(task => task.Status == "in-progress"),
            list.Count(task => task.Status == "done")
        );
    }
}
