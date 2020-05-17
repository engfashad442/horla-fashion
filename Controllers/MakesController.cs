using System.Collections.Generic;
using System.Threading.Tasks;
using ahmad.Models;
using ahmad.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ahmad.Controllers
{
    public class MakesController : Controller
    {
        private readonly AhmadDbContext context;
        public MakesController(AhmadDbContext context)
        {
            this.context = context;
        }
        [HttpGet("/api/makes")]
        public  async Task<IEnumerable<Make>>GetMakes()
        {
           return await context.makes.Include(m => m.Models).ToListAsync();

        }


    }
}