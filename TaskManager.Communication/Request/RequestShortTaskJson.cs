using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Request;

public class RequestShortTaskJson
{
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public Priority Priority { get; set; }
    public DateTime LimitDate { get; set; }
    public Status Status { get; set; }
}