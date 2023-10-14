using Microsoft.EntityFrameworkCore;
using Urans.Data;
using Urans.Interface;
using Task = System.Threading.Tasks.Task;

namespace Urans.Repastory;

public class TaskRepastory : ITaskRepastory
{
    private readonly AppDbContext _appDbContext;
    public TaskRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async System.Threading.Tasks.Task AddTaskAsync(Urans.Entities.Task taskDto)
    {
        var task = new Urans.Entities.Task();
        task.Title = taskDto.Title;
        task.Description = taskDto.Description;
        task.DateTime = taskDto.DateTime;
        task.eProcess = taskDto.eProcess;
        var findLesson = await _appDbContext.Lessons.FindAsync(taskDto.Lessons.Id);
        if (findLesson != null) task.eProcess = taskDto.eProcess;
        _appDbContext.Task.Add(task);
        await _appDbContext.SaveChangesAsync();
    }

    public async System.Threading.Tasks.Task DeleteTaskAsync(int id)
    {
        var task = await _appDbContext.Task.FindAsync(id);
        if (task != null)
        {
            _appDbContext.Task.Remove(task);
            await _appDbContext.SaveChangesAsync();
        }
    }

   public async Task<List<Entities.Task>> GetAllTaskAsync(string id)
    {
        return await _appDbContext.Task
       .Where(x => x.Id == id).Include(c =>c.Lessons).ToListAsync();
    }

    public Task<Entities.Task> GetTaskByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTaskAsync(int id, Entities.Task taskDto)
    {
        throw new NotImplementedException();
    }
}
