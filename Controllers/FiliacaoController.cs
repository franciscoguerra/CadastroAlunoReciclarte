using CadastroAlunoReciclarte.Context;
using CadastroAlunoReciclarte.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunoReciclarte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiliacaoController : ControllerBase
    {
        private readonly CadastroAlunoReciclarteDbContext _filiacaoContext;
        public FiliacaoController(CadastroAlunoReciclarteDbContext context)
        {
            _filiacaoContext= context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Filiacao>>> GetFiliacoes()
        {
            if(_filiacaoContext.Filiacaos == null)
            {
                return NotFound();
            }

            return await _filiacaoContext.Filiacaos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Filiacao>> GetById(int id)
        {
            if(_filiacaoContext.Filiacaos == null)
            {
                return NotFound();
            }

            var filiacao = await _filiacaoContext.Filiacaos.FindAsync(id);
            if(filiacao == null)
            {
                return NotFound();
            }

            return (filiacao);
        }

        [HttpPost]
        public async Task<ActionResult<Filiacao>> PostFiliacao(Filiacao filiacao)
        {
            if(_filiacaoContext.Filiacaos!= null)
            {
                return Problem("Entity set 'CadastroAlunoReciclarteDbContext' is null");
            }

            _filiacaoContext.Filiacaos.Add(filiacao);
            await _filiacaoContext.SaveChangesAsync();
            return CreatedAtAction("GetFiliacao", new { id = filiacao.id }, filiacao);
            
        }
    }
}
