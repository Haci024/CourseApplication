using AutoMapper;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.AutoMapper
{
    public class FilialMapper:Profile
    {
        public FilialMapper()
        {
            CreateMap<Filial, Filial>().ReverseMap();
            
        }
    }
}
