using AgendaContato22.Context;
using AgendaContato22.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaContato22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContatoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contato>>> GetContatos()
        {
            return await _context.Contatos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Contato>> GetContato(int id)
        {
            var contato = await _context.Contatos.FindAsync(id);

            if (contato == null)
            {
                return NotFound();
            }

            return contato;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutContato(int id, Contato contato)
        {
            if (id != contato.Id)
            {
                return BadRequest();
            }

            _context.Entry(contato).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContatoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Contato>> PostContato(Contato contato)
        {
            _context.Contatos.Add(contato);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContato", new { id = contato.Id }, contato);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarContato(int id)
        {
            var contato = await _context.Contatos.FindAsync(id);
            if(contato == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contato);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContatoExists(int id)
        {
            return _context.Contatos.Any(e => e.Id == id);
        }
    }
}
