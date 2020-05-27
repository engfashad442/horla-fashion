using System.Collections.Generic;
using System.Threading.Tasks;
using ahmad.Controllers.Resources;
using ahmad.Models;
using ahmad.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ahmad.Controllers
{
    public class MakesController : Controller
    {
        private readonly AhmadDbContext context;
        public IMapper Mapper { get; }
        public MakesController(AhmadDbContext context, IMapper mapper)
        {
            this.Mapper = mapper;
            this.context = context;
        }
        [HttpGet("/api/makes")]
        //public async Task<IEnumerable<Make>> GetMakes()
         public async Task<IEnumerable<MakeResource>> GetMakes()
        {
           // return await context.makes.Include(m => m.Models).ToListAsync();
            var makes = await context.makes.Include(m => m.Models).ToListAsync();
            return Mapper.Map<List<Make> , List<MakeResource>>(makes);

        }
    }
}