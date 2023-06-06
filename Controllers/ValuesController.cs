using CadastroAlunoReciclarte.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CadastroAlunoReciclarte.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        private readonly CadastroAlunoReciclarteDbContext _contextEscola;
        public ValuesController(CadastroAlunoReciclarteDbContext context)
        {
            _contextEscola= context;
        }
    }
}
