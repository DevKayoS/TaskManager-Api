using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Tasks.Create;
using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status201Created)]
        public IActionResult CreateTask(RequestTaskJson request)
        {
            var useCase = new CreateTaskUseCase();
            var response = useCase.Execute(request);
            
            return Created(String.Empty, response);
        }
    }
}
