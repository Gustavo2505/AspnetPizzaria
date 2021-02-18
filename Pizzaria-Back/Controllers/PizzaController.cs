using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapidotnet.Data;
using webapidotnet.Model;

namespace webapidotnet.Controllers
{
    
        [ApiController]
        [Route("v1/Pizza")]

        public class PizzaController : ControllerBase{
            [HttpGet]
            [Route("")]
            public async Task<ActionResult<List<Pizza>>> Get([FromServices] DataContext context){
            var Pizzas = await context.Pizzas.ToListAsync();
            return Pizzas;
        }

             [HttpPost]
        [Route("")]
        public async Task<ActionResult<Pizza>> post(
            [FromServices] DataContext context, [FromBody] Pizza model)
            {
                if(ModelState.IsValid){
                context.Pizzas.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else{
                return BadRequest(ModelState);
            }
        }


    }
       
        
    }
