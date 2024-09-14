using TaskManager.Application.UseCases.InMemory.Task;
using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.Create;

public class CreateTaskUseCase : InMemoryTask
{
    public ResponseTaskJson Execute(RequestTaskJson request)
    {
        var newtask = new ResponseTaskJson
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            LimitDate = request.LimitDate,
            Priority = request.Priority,
            Status = request.Status
        };

        Tasks.Add(newtask);

        return newtask;
    }
}