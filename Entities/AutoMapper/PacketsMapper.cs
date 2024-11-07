using AutoMapper;
using Entities.DTOS.Packets;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.AutoMapper
{
    public class PacketsMapper:Profile
    {
        public PacketsMapper()
        {
            CreateMap<Packets, PacketListDTO>().ReverseMap();     
        }
    }
}
