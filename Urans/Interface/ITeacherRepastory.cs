using Urans.Entities;
using Task = System.Threading.Tasks.Task;

namespace Urans.Interface;
public interface ITeacherRepastory
{
    Task<List<Teacher>> GetAllTeacheAsync();
    Task<Teacher> GetTeacheByIdAsync(int id);
    Task<Teacher> AddTecherAsync(Teacher teacher);
    Task UpdateTeacherAsync(Teacher teacher);
    Task<Teacher> DeleteTeacherAsync(int id);
    Task DeleteTeacherAsyncx(int id);
}
