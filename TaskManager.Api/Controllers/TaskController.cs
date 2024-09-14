using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Tasks.Create;
using TaskManager.Application.UseCases.Tasks.Delete;
using TaskManager.Application.UseCases.Tasks.GetAll;
using TaskManager.Application.UseCases.Tasks.GetUniqueById;
using TaskManager.Application.UseCases.Tasks.Update;
using TaskManager.Communication.Enum;
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

        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseTaskJson>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var useCase = new GetAllTasksUseCase();
            var response = useCase.Execute();
            
            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson),StatusCodes.Status404NotFound)]
        public IActionResult GetUniqueById([FromRoute] int id)
        {
            var useCase = new GetUniqueByIdUseCase();
            var response = useCase.Execute(id);

            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public IActionResult Update([FromRoute] int id, [FromBody] RequestShortTaskJson request)
        {
            var useCase = new UpdateTaskUseCase();
            useCase.Execute(id, request);
            
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete([FromRoute] int id)
        {
            var useCase = new DeleteTaskUseCase();
            useCase.Execute(id);
            
            return NoContent();
        }
    }
}
