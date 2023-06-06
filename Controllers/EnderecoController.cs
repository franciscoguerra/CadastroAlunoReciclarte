using CadastroAlunoReciclarte.Context;
using CadastroAlunoReciclarte.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroAlunoReciclarte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly CadastroAlunoReciclarteDbContext _enderecoContext;
        public EnderecoController(CadastroAlunoReciclarteDbContext contex)
        {
            _enderecoContext= contex;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Endereco>>> GetEndereco()
        {
            if(_enderecoContext.Enderecos == null) 
            { 
            return NotFound();
            }

           return await _enderecoContext.Enderecos.ToListAsync();
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Endereco>> GetById(int id)
        {
            if(_enderecoContext.Enderecos == null)
            {
                return NotFound();
            }

            var endereco = await _enderecoContext.Enderecos.FindAsync(id);
            if(endereco == null)
            {
                return NotFound();
            }

            return (endereco);
        }

        [HttpPost]
        public async Task<ActionResult<Endereco>> PostEndereco([FromBody] Endereco endereco)
        {
            if(_enderecoContext.Enderecos == null)
            {
                return Problem("Entity set 'CadastroAlunoReciclarteDbContext' is null");
            }

            _enderecoContext.Enderecos.Add(endereco);
            await _enderecoContext.SaveChangesAsync();
            return CreatedAtAction("GetEndereco", new {id = endereco.Id},endereco);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Endereco>> PutEndereco(Endereco endereco, int id)
        {
            if(id != endereco.Id)
            {
                return BadRequest();
            }

            _enderecoContext.Enderecos.Entry(endereco).State = EntityState.Modified;

            try
            {
               await _enderecoContext.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!EnderecoExiste(id))
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
        public async Task<ActionResult<Endereco>>  DeliteEndereco(int id)
        {
            if(_enderecoContext.Enderecos == null)
            {
                NotFound();
            }

            var endereco = await _enderecoContext.Enderecos.FindAsync(id);
            if(endereco == null)
            {
                return NotFound();
            }

            _enderecoContext.Enderecos.Remove(endereco);
            await _enderecoContext.SaveChangesAsync();

            return NoContent();
        }

        private bool EnderecoExiste(int id)
        {
            return (_enderecoContext.Enderecos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
