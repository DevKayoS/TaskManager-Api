using TaskManager.Application.UseCases.InMemory.Task;
using TaskManager.Communication.Request;

namespace TaskManager.Application.UseCases.Tasks.Update;

public class UpdateTaskUseCase : InMemoryTask
{
    public void Execute(int id, RequestShortTaskJson request)
    {
        var task = Tasks.FirstOrDefault(task => task.Id == id);
        
        task.Name = request.Name;
        task.Description = request.Description;
        task.Status = request.Status;
        task.Priority = request.Priority;
        task.LimitDate = request.LimitDate;
        
    }
}