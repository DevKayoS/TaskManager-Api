using TaskManager.Application.UseCases.InMemory.Task;
using TaskManager.Communication.Response;

namespace TaskManager.Application.UseCases.Tasks.GetAll;

public class GetAllTasksUseCase : InMemoryTask
{
    public List<ResponseTaskJson> Execute()
    {   
        return Tasks;
    }
}