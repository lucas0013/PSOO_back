using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lojaGeekAPI.Models;

namespace lojaGeekAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrinhoController : ControllerBase
    {
        private readonly lojaGeekAPIContext _context;

        public CarrinhoController(lojaGeekAPIContext context)
        {
            _context = context;
            _context.Carrinho.Include(x => x.Produtos).ToList();
        }

        // GET: api/Carrinho
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carrinho>>> GetCarrinho()
        {
            return await _context.Carrinho.ToListAsync();
        }

        // GET: api/Carrinho/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carrinho>> GetCarrinho(int id)
        {
            var carrinho = await _context.Carrinho.FindAsync(id);

            if (carrinho == null)
            {
                return NotFound();
            }

            return carrinho;
        }

        // PUT: api/Carrinho/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarrinho(int id, Carrinho carrinho)
        {
            if (id != carrinho.Id)
            {
                return BadRequest();
            }

            _context.Entry(carrinho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrinhoExists(id))
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

        // POST: api/Carrinho
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Carrinho>> PostCarrinho(Carrinho carrinho)
        {
            _context.Carrinho.Add(carrinho);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarrinho", new { id = carrinho.Id }, carrinho);
        }

        // DELETE: api/Carrinho/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarrinho(int id)
        {
            var carrinho = await _context.Carrinho.FindAsync(id);
            if (carrinho == null)
            {
                return NotFound();
            }

            _context.Carrinho.Remove(carrinho);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarrinhoExists(int id)
        {
            return _context.Carrinho.Any(e => e.Id == id);
        }
    }
}
