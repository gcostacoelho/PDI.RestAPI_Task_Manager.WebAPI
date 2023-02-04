namespace PDI.RestAPI_Task_Manager.WebAPI.src.Interfaces
{
    public interface ITaskRepository
    {
        Task<IEnumerable<Classes.Task>> Get();
        Task<Classes.Task> Get(int id);
        Task<Classes.Task> Create(Classes.Task task);
        System.Threading.Tasks.Task Update(Classes.Task task);
        System.Threading.Tasks.Task Delete(int id);
    }
}