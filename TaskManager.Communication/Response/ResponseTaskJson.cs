using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Response;

public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public Priority Priority { get; set; }
    public DateTime LimitDate { get; set; }
    public Status Status { get; set; }
    
}