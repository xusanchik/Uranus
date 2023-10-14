using Microsoft.EntityFrameworkCore;
using Urans.Data;
using Urans.Entities;
using Urans.Interface;
using Task = System.Threading.Tasks.Task;

namespace Urans.Repastory;
public class CoursRepastory : ICourseRepastory
{
    private readonly AppDbContext _appDbContext;
    public CoursRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<Course> Add(Course course)
    {
        _appDbContext.Course.Add(course);
        await _appDbContext.SaveChangesAsync();
        return course;

    }

    public async System.Threading.Tasks.Task Delete(int id)
    {
        var getid = await _appDbContext.Course.FindAsync(id);
        if (getid != null)
        {
            _appDbContext.Course.Remove(getid);
            await _appDbContext.SaveChangesAsync();
        }
    }

    public async Task<List<Course>> GetAllCourse()
    {
        var list = await _appDbContext.Course.ToListAsync();
        return list;
    }

    public async Task<Course> GetCourseById(int id)
    {
        var getid = await _appDbContext.Course.FindAsync(id);
        return getid;
    }

    public async System.Threading.Tasks.Task Update(Course course)
    {
        _appDbContext.Entry(course).State = EntityState.Modified;
        await _appDbContext.SaveChangesAsync();
    }
}
