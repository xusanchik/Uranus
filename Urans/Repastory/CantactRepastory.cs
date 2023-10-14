using Microsoft.EntityFrameworkCore;
using Urans.Data;
using Urans.Entities;
using Urans.Interface;
using Task = System.Threading.Tasks.Task;

namespace Urans.Repastory;
public class CantactRepastory : IContactRepastory
{
    private readonly AppDbContext _appDb;
    public CantactRepastory(AppDbContext appDb)
    {
        _appDb = appDb;   
    }
    public async Task<Contact> AddContact(Contact contact)
    {
        _appDb.Contact.Add(contact);
        await _appDb.SaveChangesAsync();
        return contact;
    }

    public async Task Delete(int id)
    {
        var contact = await _appDb.Contact.FindAsync(id);
        if (contact != null)
        {
            _appDb.Contact.Remove(contact);
            await _appDb.SaveChangesAsync();
        }
    }

    public async Task<List<Contact>> GetAll()
    {
        var contacts = await _appDb.Contact.ToListAsync();

        return contacts;
    }

  
}
