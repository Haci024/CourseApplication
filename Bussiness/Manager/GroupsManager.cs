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
    public class GroupsManager : IGroupService
    {
        private readonly IGroupRepository _repository;
        public GroupsManager(IGroupRepository groupRepository)
        {
            _repository = groupRepository;
        }
        public async Task Add(Groups entity)
        {
            await _repository.Add(entity);
        }

        public async Task Delete(Groups entity)
        {
          await _repository.Delete(entity);
        }

        public async Task<Groups> GetById(int Id)
        {
            return await _repository.GetById(Id);
        }

        public async Task<Groups> GetById(long Id)
        {
            return await  _repository.GetById(Id);
        }

        public async  Task<Groups> GetById(Guid Id)
        {
            return await _repository.GetById(Id);
        }

        public async Task<IEnumerable<Groups>> GetList()
        {
            return await _repository.GetList();
        }

        public async Task Update(Groups entity)
        {
           await _repository.Update(entity);
        }
    }
}
