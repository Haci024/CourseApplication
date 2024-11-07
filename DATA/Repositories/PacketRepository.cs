using Data.Connection;
using Data.DAL;
using Entities.DTOS.Packets;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PacketRepository:GenericRepository<Packets>,IPacketRepository
    {
        private readonly AppDbContext _db;
        public PacketRepository(AppDbContext db):base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Packets>> ActivePacketList()
        {

            return await _db.Packets.Where(x=>x.Status==true).ToListAsync();
        
        }

        public async Task<IEnumerable<Packets>> DeactivePacketList()
        {

            return await _db.Packets.Where(x => x.Status == false).ToListAsync();
        }

    }
}
