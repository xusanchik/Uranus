using Microsoft.EntityFrameworkCore;
using Urans.Entities;
using Tack = System.Threading.Tasks.Task;

namespace Urans.Data;
public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> User { get; set; }
    public DbSet<Teacher> Teacher { get; set; }
    public DbSet<Contact> Contact { get; set; }
    public DbSet<Test> Test { get; set; }
    public DbSet<Course> Course { get; set; }
    public DbSet<Education> Education { get; set; }
    public DbSet<Feedback> Feedback { get; set; }
    public DbSet<Reslut> Reslut { get; set; }
    public DbSet<Lessons> Lessons { get; set; }
    public DbSet<Urans.Entities.Task> Task { get; set; }
    public DbSet<Homwork> Homwork { get; set; }
    public DbSet<TaskAnswer> TaskAnswers { get; set; }
}
