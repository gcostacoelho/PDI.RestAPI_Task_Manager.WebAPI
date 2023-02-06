using Microsoft.EntityFrameworkCore;
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
        public async Task<Classes.Task> Create(Classes.Task task)
        {
            _taskContext.Tasks.Add(task);
            await _taskContext.SaveChangesAsync();

            return task;
        }

        public async System.Threading.Tasks.Task Delete(int id)
        {
            var taskToDelete = await _taskContext.Tasks.FindAsync(id);
            _taskContext.Tasks.Remove(taskToDelete);

            await _taskContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Classes.Task>> Get()
        {
            return await _taskContext.Tasks.ToListAsync();
        }

        public async Task<Classes.Task> Get(int id)
        {
            return await _taskContext.Tasks.FindAsync(id);
        }

        public async System.Threading.Tasks.Task Update(Classes.Task task)
        {
            _taskContext.Entry(task).State = EntityState.Modified;

            await _taskContext.SaveChangesAsync();
        }
    }
}