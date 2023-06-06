using CadastroAlunoReciclarte.Context;
using CadastroAlunoReciclarte.Migrations;
using CadastroAlunoReciclarte.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunoReciclarte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly CadastroAlunoReciclarteDbContext _cursoContext;
        public CursoController(CadastroAlunoReciclarteDbContext context)
        {
            _cursoContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Curso>>> GetCursos()
        {
            if (_cursoContext.Cursos == null)
            {
                return NotFound();
            }
            return await _cursoContext.Cursos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Curso>> GetById(int id)
        {
            if (_cursoContext.Cursos == null)
            {
                return NotFound();
            }

            var curso = await _cursoContext.Cursos.FindAsync(id);

            if (curso == null)
            {
                
                return NotFound();
            }
            return (curso);
        }

        [HttpPost]
        public async Task<ActionResult<Curso>> PostCurso(Curso curso)
        {
            if (_cursoContext.Turmas == null)
            {
                return Problem(" Entity set 'CadastroAlunoReciclarteDbContext' is null.");
            }

            _cursoContext.Cursos.Add(curso);
            await _cursoContext.SaveChangesAsync();

            return CreatedAtAction("GetCurso", new { id = curso.Id }, curso);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Curso>> PutCurso([FromBody] Curso curso, int id)
        {
            if(id != curso.Id)
            {
                return BadRequest();
            }

            _cursoContext.Entry(curso).State = EntityState.Modified;

            try
            {
                await _cursoContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!CursoExiste(id))
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
        public async Task<ActionResult<Curso>> DeliteCurso(int id)
        {
            if(_cursoContext.Cursos == null)
            {
                return NotFound();
            }

            var curso = await _cursoContext.Cursos.FindAsync(id);

            if (curso == null)
            {
                return NotFound();
            }

            try
            {
                curso.NaoExcluirCurso();
            }

            catch(Exception e)
            {
                return NotFound(e.Message);
            }
            _cursoContext.Remove(curso);
            await _cursoContext.SaveChangesAsync();

            return NoContent();
        }

        private bool CursoExiste(int id)
        {
            return (_cursoContext.Cursos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
