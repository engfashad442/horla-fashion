using System.Collections.Generic;
using System.Threading.Tasks;
using ahmad.Models;
using ahmad.Persistence;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ahmad.Controllers.Resources;
using Microsoft.AspNetCore.Mvc;

namespace ahmad.Controllers
{
    public class FeaturesController
    {
        private readonly IMapper mapper;
        private readonly AhmadDbContext context;
        public FeaturesController(AhmadDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;

        }
          
          [HttpGet("/api/features")]
         public  async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
            {

                var features =  await context.Features.ToListAsync();
                return  mapper.Map<List<Feature>, List<KeyValuePairResource>>(features);
            }
    }
}