using CadastroAlunoReciclarte.Context;
using CadastroAlunoReciclarte.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunoReciclarte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        private readonly CadastroAlunoReciclarteDbContext _escolaContext;
        public EscolaController(CadastroAlunoReciclarteDbContext context)
        {
            _escolaContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Escola>>> GetEscolas()
        {
            if (_escolaContext.Escolas == null)
            {
                return NotFound();
            }

            return await _escolaContext.Escolas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Escola>> GetById(int id)
        {
            if (_escolaContext.Escolas == null)
            {
                return NotFound();
            }

            var endereco = await _escolaContext.Escolas.FindAsync(id);

            if (endereco == null)
            {
                return NotFound();
            }

            return (endereco);
        }

        [HttpPost]
        public async Task<ActionResult<Escola>> PostEscola(Escola escola)
        {
            if (_escolaContext.Escolas != null)
            {
                return Problem("Entity set ' CadastroAlunoReciclarteDbContext' in null ");
            }

            _escolaContext.Escolas.Add(escola);
            await _escolaContext.SaveChangesAsync();
            return CreatedAtAction("GetEscola", new { id = escola.Id }, escola);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Escola>> PutEscola(Escola escola, int id)
        {
            if (id != escola.Id)
            {
                return BadRequest();
            }

            _escolaContext.Escolas.Entry(escola).State = EntityState.Modified;

            try
            {
                await _escolaContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EscolaExiste(id))
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


        [HttpDelete("{id}")]
        public async Task<ActionResult<Escola>> DeliteEscola(int id)
        {
            if(_escolaContext.Escolas==null)
            {
                return NotFound();
            }

            var escola = await _escolaContext.Escolas.FindAsync(id);

            if(escola == null) 
            { 
                return NotFound();
            }

            _escolaContext.Escolas.Remove(escola);
            await _escolaContext.SaveChangesAsync();

            return NoContent();
        }

        private bool EscolaExiste(int id)
        {
            return (_escolaContext.Enderecos?.Any(e => e.Id == id)).GetValueOrDefault();
        }

    }
}
