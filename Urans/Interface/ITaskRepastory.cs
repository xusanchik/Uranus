using Task = System.Threading.Tasks.Task;

namespace Urans.Interface;
public interface ITaskRepastory
{
    Task<List<Urans.Entities.Task>> GetAllTaskAsync(string id);
    Task<Urans.Entities.Task> GetTaskByIdAsync(int id);
    Task AddTaskAsync(Urans.Entities.Task taskDto);
    Task UpdateTaskAsync(int id, Urans.Entities.Task taskDto);
    Task DeleteTaskAsync(int id);
}
