using Microsoft.EntityFrameworkCore;
using Urans.Data;
using Urans.Entities;
using Urans.Interface;
using System.Linq;
using Task = System.Threading.Tasks.Task;

namespace Urans.Repastory;
public class HomworkRepastory : IHomworkRepastory
{
    private readonly AppDbContext _appDbContext;
    public HomworkRepastory(AppDbContext appDbContext) => _appDbContext = appDbContext;
    public async System.Threading.Tasks.Task AddHomeworkAsync(Homwork homeworkDto)
    {
        var homework = new Homwork();
        homework.Description = homeworkDto.Description;
        var findLesson = await _appDbContext.Course.FindAsync(homeworkDto.Task.Id);
        if (findLesson != null) homework.Task = homeworkDto.Task;
        _appDbContext.Homwork.Add(homework);
        await _appDbContext.SaveChangesAsync();
    }

    public async System.Threading.Tasks.Task DeleteHomeworkAsync(int id)
    {
        var homework = await _appDbContext.Homwork.FindAsync(id);
        if (homework != null)
        {
            _appDbContext.Homwork.Remove(homework);
            await _appDbContext.SaveChangesAsync();
        }
    }

    public async Task<List<Homwork>> GetAllHomeworkAsync()
    {
        var homework = await _appDbContext.Homwork
       .Include(e => e.Task)
       .Select(e => new Homwork()
       {
           Id = e.Id,
           Description = e.Description,
           Task = e.Task
       })
       .ToListAsync();
        return homework;
    }

    public async Task<Homwork> GetHomeworkByIdAsync(int id)
    {
        var getid = await _appDbContext.Homwork.FindAsync(id);
        return getid;
    }

    public async System.Threading.Tasks.Task UpdateHomeworkAsync(int id, Homwork homeworkDto)
    {
        var homeworkFindAsync = await _appDbContext.Homwork.FindAsync(id);
        homeworkFindAsync.Description = homeworkDto.Description;
        homeworkFindAsync.Task = homeworkDto.Task;

        _appDbContext.Entry(homeworkFindAsync).State = EntityState.Modified;
        await _appDbContext.SaveChangesAsync();
    }
}
