using Urans.Dto_s;
using Urans.Entities;
using Task = System.Threading.Tasks.Task;


namespace Urans.Repastory;
public interface IUserRepastory
{
    Task<User> Registraktion(LoginDto loginDto);
    Task<User> login(ChekLogin chekLogin);
    Task<User> GetUserById(int id);
    Task UpdateUserAsync(int id,User user);
    Task<List<Course>> GetUserCourses(int id);

}
