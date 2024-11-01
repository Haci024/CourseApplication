using Data.DbConnection;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
    

        private readonly AppDbContext _db;

        public TestController(AppDbContext db)
        {
            _db = db;
        }
        [HttpPost("AddData")]
        public IActionResult AddData(TestTable data)
        {
            _db.Add(data);
            _db.SaveChanges();
            return Ok(data);
                
        }

      
    }
}
