using AutoMapper;
using Bussiness.Services;
using Data.DAL;
using Entities.DTOS.Packets;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Manager
{
    public class PacketsManager : IPacketService
    {
        private readonly IPacketRepository _repo;
        private readonly IMapper _mapper;

        public PacketsManager(IPacketRepository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper=mapper;
        }

        public async Task<IEnumerable<PacketListDTO>> ActivePackets()
        {
            
            return  _mapper.Map<IEnumerable<PacketListDTO>>(await _repo.ActivePacketList());
            
            
        }

        public async Task Add(Packets dto)
        {
            await _repo.Add(dto);
        }

        public async Task<IEnumerable<PacketListDTO>> DeactivePackets()
        {
            return _mapper.Map<IEnumerable<PacketListDTO>>(await _repo.DeactivePacketList());
        }

        public async Task Delete(Packets entity)
        {
            await _repo.Delete(entity);
        }

        public async Task<Packets> GetById(int Id)
        {
            return await _repo.GetById(Id); 
        }

        public async Task<Packets> GetById(long Id)
        {
            return await _repo.GetById(Id);
        }

        public  async Task<Packets> GetById(Guid guid)
        {
            return await _repo.GetById(guid);
        }

        public async Task<IEnumerable<Packets>> GetList()
        {
            return await _repo.GetList();
        }

        public async Task Update(Packets dto)
        {
            await _repo.Update(dto);

        }
    }
}
