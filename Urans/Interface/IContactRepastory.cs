using Urans.Entities;
using Task = System.Threading.Tasks.Task;
namespace Urans.Interface;
public interface IContactRepastory
{
    Task<List<Contact>> GetAll();
    Task <Contact>AddContact(Contact contact);
    Task Delete(int id);
}
