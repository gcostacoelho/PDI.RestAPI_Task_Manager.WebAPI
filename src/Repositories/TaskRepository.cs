using PDI.RestAPI_Task_Manager.WebAPI.src.Classes;
using PDI.RestAPI_Task_Manager.WebAPI.src.Interfaces;

namespace PDI.RestAPI_Task_Manager.WebAPI.src.Repositories
{
    public class TaskRepository : ITaskRepository
    {

        public readonly TaskContext _taskContext;

        public TaskRepository(TaskContext taskContext)
        {
            _taskContext = taskContext;
        }
        public Task<Classes.Task> Create(Classes.Task task)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Classes.Task>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Classes.Task> Get(int id)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Update(Classes.Task task)
        {
            throw new NotImplementedException();
        }
    }
}