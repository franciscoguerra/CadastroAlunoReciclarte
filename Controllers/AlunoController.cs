using CadastroAlunoReciclarte.Model;
using CadastroAlunoReciclarte.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunoReciclarte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        [HttpGet("buscar-por-id/{id}")]
        public async Task<ActionResult<Aluno>> BuscarAlunoPorId(int id) 
        {
            Aluno aluno = await _alunoRepositorio.BuscarAlunoPorId(id);
            return Ok(aluno);
        }
        [HttpGet("buscar-por-cpf/{cpf}")]
        public async Task<ActionResult<Aluno>> BuscarAlunoCpf(string cpf)
        {
            Aluno aluno = await _alunoRepositorio.BuscarAlunoCPF(cpf);
            return Ok(aluno);
        }
    }
}
