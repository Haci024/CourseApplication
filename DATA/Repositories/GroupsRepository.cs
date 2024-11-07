using Data.Connection;
using Data.DAL;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class GroupsRepository:GenericRepository<Groups>,IGroupRepository
    {
        private readonly AppDbContext _db;
        public GroupsRepository(AppDbContext db):base(db)
        {
            _db = db;
        }
    }
}
