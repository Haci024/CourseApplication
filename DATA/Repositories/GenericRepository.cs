using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data.Connection;
using Data.DAL;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _db;
       
        
        public GenericRepository(AppDbContext db) { 
            _db = db; 
        }

        public async Task Add(T entity)
        {
            _db.Set<T>().Add(entity);   
           await _db.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
           _db.Set<T>().Remove(entity);
           await _db.SaveChangesAsync();
        }

        public async Task<T> GetById(int Id)
        {
            return await _db.Set<T>().FindAsync(Id);
        }

        public async Task<T> GetById(long Id)
        {
            return await _db.Set<T>().FindAsync(Id);  
        }

        public async Task<T> GetById(Guid Id)
        {
            return await _db.Set<T>().FindAsync(Id);
        }

        public async  Task<IEnumerable<T>> GetList()
        {
           return _db.Set<T>().ToList();
        }

        public async Task Update(T entity)
        {
               _db.Set<T>().Add(entity) ;
            await _db.SaveChangesAsync();
        }
    }
}
