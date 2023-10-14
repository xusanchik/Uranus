using Microsoft.EntityFrameworkCore;
using Urans.Data;
using Urans.Dto_s;
using Urans.Entities;
using Task = System.Threading.Tasks.Task;

namespace Urans.Repastory;
public class UserRepastory : IUserRepastory
{
    private readonly AppDbContext _appDbContext;
    public UserRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<User> GetUserById(int id)
    {
        var user = await _appDbContext.User.FindAsync(id);
        return user;
    }

    public async Task<List<Course>> GetUserCourses(int id)
    {
        var user = await _appDbContext.Course.ToListAsync();
        var usercours = user.FindAll(x => x.Id == id);
        return usercours;
    }

    public async Task<User> login(ChekLogin chekLogin)
    {
        var userFind =
           await _appDbContext.User.FirstOrDefaultAsync(u =>
               u.Email == chekLogin.Email && u.Password == chekLogin.Password);
        return userFind;
    }

    public async Task<User> Registraktion(LoginDto loginDto)
    {
        var user = new User();
        user.Email = loginDto.Email;
        user.Name = loginDto.FullName;
        user.Password = loginDto.Password;
        _appDbContext.User.Add(user);
        await _appDbContext.SaveChangesAsync();
        return user;
    }


    public async Task UpdateUserAsync(int id, User user)
    {
        var idget = await _appDbContext.User.FindAsync(id);
        _appDbContext.Entry(idget).State = EntityState.Modified;
        await _appDbContext.SaveChangesAsync();

    }
}
