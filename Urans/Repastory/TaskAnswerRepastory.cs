using Microsoft.EntityFrameworkCore;
using Urans.Data;
using Urans.Entities;
using Urans.Interface;
using Task = System.Threading.Tasks.Task;

namespace Urans.Repastory;
public class TaskAnswerRepastory : ITaskAnswerRepastory
{
    private readonly AppDbContext _appDbContext;
    public TaskAnswerRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<TaskAnswer> AddTaskAnswer(TaskAnswer taskAnswer)
    {
        var task = new TaskAnswer()
        {
            Answer = taskAnswer.Answer,
            Task = taskAnswer.Task
        };
        _appDbContext.TaskAnswers.Add(task);
        await _appDbContext.SaveChangesAsync();
        return task;
    }

    public async Task<List<TaskAnswer>> GetTaskAnswerList()
    {
        var lis = await _appDbContext.TaskAnswers.ToListAsync();
        return lis;
    }
}
