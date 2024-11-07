using Data.Connection;
using Data.DAL;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class FilialRepository: GenericRepository<Filial>, IFilialRepository
    {
        private readonly AppDbContext _db;
        public FilialRepository(AppDbContext db):base(db)
        {
            _db = db;
        }
        
       
    }
}
