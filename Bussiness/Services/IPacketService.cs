using Entities.DTOS.Packets;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Services
{
    public interface IPacketService:IGenericService<Packets>
    {
        Task<IEnumerable<PacketListDTO>> ActivePackets();
        Task<IEnumerable<PacketListDTO>> DeactivePackets();
    }
}
