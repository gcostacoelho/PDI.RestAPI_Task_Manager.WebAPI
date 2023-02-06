using Microsoft.AspNetCore.Mvc;
using PDI.RestAPI_Task_Manager.WebAPI.src.Interfaces;

namespace PDI.RestAPI_Task_Manager.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet("/tasks")]
        public async Task<IEnumerable<src.Classes.Task>> getTasks()
        {
            return await _taskRepository.Get();
        }

        [HttpGet("/tasks/{id}")]
        public async Task<ActionResult<src.Classes.Task>> getTasksbyId(int id)
        {
            return await _taskRepository.Get(id);
        }

        [HttpPost("/tasks/create")]
        public async Task<ActionResult<src.Classes.Task>> createTask([FromQuery] src.Classes.Task task)
        {
            return await _taskRepository.Create(task);
        }

        [HttpPut("/tasks/update/{id}")]
        public async Task<ActionResult<src.Classes.Task>> updateTask([FromQuery] src.Classes.Task task, int id)
        {
            if (id != task.id)
            {
                return BadRequest();
            }

            await _taskRepository.Update(task);
            return task;
        }

        [HttpDelete("/tasks/delete/{id}")]
        public async Task<ActionResult<src.Classes.Task>> deleteTask(int id)
        {
            var taskToDelete = await _taskRepository.Get(id);

            if (taskToDelete == null)
            {
                return NotFound();
            }

            await _taskRepository.Delete(taskToDelete.id);

            return NoContent();
        }
    }
}