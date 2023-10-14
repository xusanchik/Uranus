namespace Urans.Interface;
using Task = System.Threading.Tasks.Task;
public interface IResultRepastory
{
    Task<List<Entities.Reslut>> GetAllResultAsync();
    Task<Entities.Reslut> GetResultByIdAsync(int id);
    Task AddResultAsync(Entities.Reslut result);
    Task DeleteResultAsync(int id);
    Task UpdateResultAsync(Entities.Reslut result);
    Task<List<Entities.Reslut>> GetUserResult(int userId);
}
