using TaskManager.Application.UseCases.InMemory.Task;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.GetUniqueById;

public class GetUniqueByIdUseCase : InMemoryTask
{
    public ResponseTaskJson Execute(int id)
    {
        var response = Tasks.Find(task => task.Id == id);

        return response;
    }
}