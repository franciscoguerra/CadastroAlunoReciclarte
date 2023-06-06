using CadastroAlunoReciclarte.Context;
using CadastroAlunoReciclarte.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunoReciclarte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly CadastroAlunoReciclarteDbContext _contextTurma;
        public TurmaController(CadastroAlunoReciclarteDbContext context)
        {
            _contextTurma = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Turma>>> GetTurma() 
        { 
            if(_contextTurma.Turmas == null)
            {
                return NotFound();
            }

            return await _contextTurma.Turmas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Turma>> GetById(int id)
        {
            if(_contextTurma.Turmas==null)
            {
                return NotFound(id);
            }

            var turma = await _contextTurma.Turmas.FindAsync(id);
            if(turma==null)
            {
                return NotFound();
            }
            return (turma);
        }

        [HttpPost]
        public async Task<ActionResult<Turma>>  PostTurma(Turma turma)
        {
            if(_contextTurma.Turmas == null)
            {
                return Problem("Entity set 'CadastroAlunoReciclarteDbContext' is null");
            }

            try
            {
                turma.QtdsAlunos();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }

            try
            {
                turma.CadastroAluno();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }

            _contextTurma.Turmas.Add(turma);
            await _contextTurma.SaveChangesAsync();

            return CreatedAtAction("GetTurma", new { id = turma.Id}, turma);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Turma>> PutTurma([FromBody] Turma turma, int id)
        {
            if(id != turma.Id) 
            {
                return BadRequest();
            }

            _contextTurma.Entry(turma).State= EntityState.Modified;

            try
            {
                await _contextTurma.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!TurmaExiste(id))
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
        public async Task<ActionResult<Turma>> DeliteTurma(int id)
        {
            if(_contextTurma.Turmas == null)
            {
                return NotFound() ;
            }

            var turma = await _contextTurma.Turmas.FindAsync(id);

            if(turma == null)
            {
                return NotFound();
            }

            try
            {
                turma.NaoEcluirTurma();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }

            _contextTurma.Turmas.Remove(turma);
            await _contextTurma.SaveChangesAsync();

            return NoContent();
        }



        private bool TurmaExiste(int id)
        {
            return (_contextTurma.Turmas?.Any(e => e.Id == id)).GetValueOrDefault();
        }

    }
}
