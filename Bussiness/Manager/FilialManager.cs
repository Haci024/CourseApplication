using Bussiness.Services;
using Data.DAL;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Manager
{
    public class FilialManager : IFilialService
    {
        private readonly IFilialRepository _repo;
        public FilialManager(IFilialRepository repo)
        {
            _repo = repo;
        }
        public async Task Add(Filial entity)
        {
            await _repo.Add(entity);
        }

        public async Task Delete(Filial entity)
        {
            await _repo.Delete(entity);
        }

        public Task<Filial> GetById(int Id)
        {
            return _repo.GetById(Id);
        }

        public Task<Filial> GetById(long Id)
        {
            return _repo.GetById(Id);
        }

        public async Task<Filial> GetById(Guid Id)
        {
           return await _repo.GetById(Id);
        }

        public async Task<IEnumerable<Filial>> GetList()
        {
            return await _repo.GetList();
        }

        public async Task Update(Filial entity)
        {
            await _repo.Update(entity);
        }
    }
}
