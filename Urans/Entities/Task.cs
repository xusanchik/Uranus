using Urans.Entities.Enams;
namespace Urans.Entities;
public class Task
{
    public string Id { get; set; }
    public string Name { get; set; }
    public Lessons Lessons { get; set; }
    public string Description { get; set; } 
    public string Title { get; set; }
    public DateTime DateTime { get; set; }
    public EProcess eProcess { get; set; }
}
