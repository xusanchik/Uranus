using Urans.Entities;
using Task = System.Threading.Tasks.Task;

namespace Urans.Interface;
public interface ITaskAnswerRepastory
{
    Task<List<TaskAnswer>> GetTaskAnswerList();
    Task<TaskAnswer> AddTaskAnswer(TaskAnswer taskAnswer);
}
