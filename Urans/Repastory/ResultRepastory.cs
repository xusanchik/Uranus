using Microsoft.EntityFrameworkCore;
using Urans.Data;
using Urans.Entities;
using Urans.Interface;
using Task = System.Threading.Tasks.Task;

namespace Urans.Repastory
{
    public class ResultRepastory : IResultRepastory
    {
        private readonly AppDbContext _appDb;
        public ResultRepastory(AppDbContext appDb)
        {
            _appDb = appDb;
        }
        public async System.Threading.Tasks.Task AddResultAsync(Reslut result)
        {
            var results = new Reslut()
            {
                Education = result.Education,
                Url = result.Url,
                User = result.User
            };
            _appDb.Reslut.Add(results);
            await _appDb.SaveChangesAsync();
        }

        public System.Threading.Tasks.Task DeleteResultAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Reslut>> GetAllResultAsync()
        {
            return await _appDb.Reslut.ToListAsync();
        }

        public async Task<Reslut> GetResultByIdAsync(int id)
        {
            var idget = await _appDb.Reslut.FindAsync(id);
            return idget;
        }

        public Task<List<Reslut>> GetUserResult(int userId)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task UpdateResultAsync(Reslut result)
        {
            throw new NotImplementedException();
        }
    }
}
