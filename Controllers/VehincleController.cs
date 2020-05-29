using ahmad.Models;
using Microsoft.AspNetCore.Mvc;

namespace ahmad.Controllers
{
 [Route("/api/vehincles")]
    public class VehincleController: Controller
    
    {
        [HttpPost]
        public IActionResult CreateVehincle(Vehincle vehincle){
          return Ok(vehincle);

        }
    }
}