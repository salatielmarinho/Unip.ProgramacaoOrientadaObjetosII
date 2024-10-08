using Microsoft.AspNetCore.Mvc;
using API.Application.Output.DTOs;

namespace API.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CursoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Análise e Desenvolvimento de Sistemas", "Redes", "Gestão da Tecnologia da Informação"
        };

        private readonly ILogger<AlunoController> _logger;

        public CursoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCurso")]
        public IEnumerable<CursoDTO> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new CursoDTO
            {
                NomeCurso = Summaries[Random.Shared.Next(Summaries.Length)],
                Descricao = "Teste"
            })
            .ToArray();
        }
    }
}
