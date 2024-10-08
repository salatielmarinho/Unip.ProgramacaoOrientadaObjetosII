using Microsoft.AspNetCore.Mvc;
using API.Application.Output.DTOs;
using API.Application.Output.Interfaces;

namespace API.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly ILogger<AlunoController> _logger;
        private readonly IReadAlunoRepository _repository;

        public AlunoController(ILogger<AlunoController> logger, IReadAlunoRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet(Name = "GetAllAluno")]
        public IEnumerable<AlunoDTO> GetAllAluno()
        {
            return _repository.GetAllAluno();
        }        

        [HttpGet("{alunoId}", Name = "GetAlunoById")]
        public IActionResult GetAlunoById(int alunoId)
        {
            try
            {                
                var result = _repository.GetAlunoById(alunoId);
                if (result.Mensagem is null)
                {
                    return Ok(result);
                }
                else
                {
                    return NoContent();
                }                
            }
            catch(Exception)
            {
                throw new Exception("Falha ao recuperar aluno(a)");                
            }
        }
    }
}