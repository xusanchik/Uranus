using Microsoft.EntityFrameworkCore;
using Urans.Data;
using Urans.Entities;
using Urans.Interface;
using Task = System.Threading.Tasks.Task;

namespace Urans.Repastory
{
    public class TeacherRepastory : ITeacherRepastory
    {
        private readonly AppDbContext _appDbContext;
        public TeacherRepastory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public  async Task<Teacher> AddTecherAsync(Teacher teacher)
        {
            _appDbContext.Teacher.Add(teacher);
            await _appDbContext.SaveChangesAsync();
            return teacher;

        }

        public async Task DeleteTeacherAsyncx(int id)
        {
            var idt = await _appDbContext.Teacher.FindAsync(id);
            _appDbContext.Remove(idt);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<List<Teacher>> GetAllTeacheAsync()
        {
            var teachers = await _appDbContext.Teacher.ToListAsync();
            return teachers;
        }

        public async Task<Teacher> GetTeacheByIdAsync(int id)
        {
            var teacher = await _appDbContext.Teacher.FindAsync(id);
            return teacher;
        }

        public async Task UpdateTeacherAsync(Teacher teacher)
        {
            var firstOrDefaultAsync = await _appDbContext.Teacher.FirstOrDefaultAsync(u => u.Id == teacher.Id);

            if (firstOrDefaultAsync != null)
            {
                firstOrDefaultAsync.Name = teacher.Name;
                firstOrDefaultAsync.Type = teacher.Type;
                _appDbContext.Entry(firstOrDefaultAsync).State = EntityState.Modified;
                await _appDbContext.SaveChangesAsync();
            }
        }

        Task<Teacher> ITeacherRepastory.DeleteTeacherAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
