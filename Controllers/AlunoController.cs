using CadastroAlunoReciclarte.Model;
using CadastroAlunoReciclarte.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CadastroAlunoReciclarte.Context;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunoReciclarte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly CadastroAlunoReciclarteDbContext _alunoContexto;
        public AlunoController(CadastroAlunoReciclarteDbContext context)
        {
            _alunoContexto = context;
        }

        [HttpGet("buscar-por-id/{id}")]
        public async Task<ActionResult<Aluno>> GetId(int id) 
        {
           if(_alunoContexto.Alunos == null) 
            { 
                return NotFound();
            }

           var aluno = await _alunoContexto.Alunos.FindAsync(id);

            if(aluno == null)
            {
                return NotFound();
            }
            return (aluno);
        }
        [HttpGet("buscar-por-cpf/{cpf}")]
        public async Task<ActionResult<Aluno>> GetCpf(string cpf)
        {
            if (_alunoContexto.Alunos==null) 
            { 
                return NotFound();
            }
            var aluno = await _alunoContexto.Alunos.FindAsync(cpf);
            if(aluno == null)
            {
                return NotFound();
            }
            return aluno;
        }

        [HttpGet("buscar-todos-alunos")]
        public async Task<ActionResult<IEnumerable<Aluno>>> GetAlunos()
        {
            if (_alunoContexto.Alunos == null)
            {
                return NotFound();
            }
            return await _alunoContexto.Alunos.ToListAsync();
            
        }

        [HttpPost]
        public async Task<ActionResult<Aluno>> PotAluno([FromBody] Aluno aluno)
        {
            if(_alunoContexto.Alunos == null)
            {
                return Problem("Entity set 'CadastroAlunoReciclarteDbContext.Alunos' is null");
            }
            try
            {
                aluno.CpfDuplicidade();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }

            _alunoContexto.Alunos.Add(aluno);
            await _alunoContexto.SaveChangesAsync();
            return CreatedAtAction("GetAluno", new {id = aluno.Id}, aluno);
        }

        [HttpPut("/{id}")]
        public async Task<ActionResult<Aluno>> AtualizarAluno([FromBody] Aluno aluno, int id)
        {

            if(id !=aluno.Id)
            {
                return BadRequest();
            }

            _alunoContexto.Entry(aluno).State = EntityState.Modified;

            try
            {
                await _alunoContexto.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!AlunoExiste(id))
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

        [HttpDelete("/{id}")]
        public async Task<ActionResult<Aluno>> DeleteAluno(int id)
        {
            if(_alunoContexto== null)
            {
                return NotFound();
            }

            var aluno = await _alunoContexto.Alunos.FindAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }

           _alunoContexto.Alunos.Remove(aluno);
            await _alunoContexto.SaveChangesAsync();

            return NoContent();
        }

        private bool AlunoExiste(int id)
        {
            return (_alunoContexto.Alunos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
