using Urans.Entities;
using Task = System.Threading.Tasks.Task;

namespace Urans.Interface;
public interface IHomworkRepastory
{
    Task<List<Homwork>> GetAllHomeworkAsync();
    Task<Homwork> GetHomeworkByIdAsync(int id);
    Task AddHomeworkAsync(Homwork homeworkDto);
    Task UpdateHomeworkAsync(int id, Homwork homeworkDto);
    Task DeleteHomeworkAsync(int id);
}
