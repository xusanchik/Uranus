using Urans.Entities;
using Task = System.Threading.Tasks.Task;

namespace Urans.Interface;
public interface ICourseRepastory
{
    Task<List<Course>> GetAllCourse();
    Task<Course> GetCourseById(int id);
    Task<Course> Add(Course course);
    Task Update(Course course);
    Task Delete(int id);


}
