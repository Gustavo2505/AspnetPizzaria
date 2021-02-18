

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapidotnet.Data;
using webapidotnet.Model;

namespace webapidotnet.Controllers
{

    [ApiController]
    [Route("v1/restaurantes")]

    public class RestauranteController : ControllerBase
    {
        private readonly DataContext _context;
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Restaurante>>> Get([FromServices] DataContext context)
        {
            var restaurantes = await context.Restaurantes.Include(x => x.Pizza).ToListAsync();
            return restaurantes;
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Restaurante>> GetById([FromServices] DataContext context, int id)
        {
            var restaurante = await context.Restaurantes.Include(x => x.Pizza)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
            return restaurante;
        }

        [HttpGet]
        [Route("Restaurante/{id:int}")]
        public async Task<ActionResult<List<Restaurante>>> GetByPizza([FromServices] DataContext context, int id)
        {
            var restaurante = await context.Restaurantes
            .Include(x => x.Pizza)
            .AsNoTracking()
            .Where(x => x.PizzaId == id)
            .ToListAsync();
            return restaurante;

        }

        [HttpDelete("")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurante = await _context.Restaurantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (restaurante == null)
            {
                return NotFound();
            }

            return Ok(restaurante);

        }
        
        [HttpPost, ActionName("Delete")]
       
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurante = await _context.Restaurantes.FindAsync(id);
            _context.Restaurantes.Remove(restaurante);
            await _context.SaveChangesAsync();



            return RedirectToAction(nameof(Index));
        }
        private bool ProdutoExists(int id)
        {
            return _context.Restaurantes.Any(e => e.Id == id);
        }


        
      
        }


    }





