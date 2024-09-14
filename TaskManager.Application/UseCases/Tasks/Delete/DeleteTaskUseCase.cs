using TaskManager.Application.UseCases.InMemory.Task;

namespace TaskManager.Application.UseCases.Tasks.Delete;

public class DeleteTaskUseCase : InMemoryTask
{
    public void Execute(int id)
    {
        var task =  Tasks.FirstOrDefault(task => task.Id == id);
        
        Tasks.Remove(task);
    }
}