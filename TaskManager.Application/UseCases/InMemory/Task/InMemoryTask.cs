using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.InMemory.Task;

public class InMemoryTask
{
    public static List<ResponseTaskJson> Tasks { get; set; }  = [];
}