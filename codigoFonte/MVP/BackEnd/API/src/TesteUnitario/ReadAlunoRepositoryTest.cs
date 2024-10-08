using Moq;
using API.Application.Output.DTOs;
using API.Application.Output.Interfaces;

namespace API.TesteUnitario
{
    public class Tests
    {
        [Test]
        public void GetAllAluno_DeveRetornarListadeAlunos()
        {
            // Arrange
            var mockRepo = new Mock<IReadAlunoRepository>();
            mockRepo.Setup(repo => repo.GetAllAluno()).Returns(GetExampleAlunos());

            // Act
            var result = mockRepo.Object.GetAllAluno();

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Count(), Is.EqualTo(3));
        }

        [Test]
        public void GetAlunoById_DeveRetornarListadeAlunoPorId()
        {
            // Arrange
            var mockRepo = new Mock<IReadAlunoRepository>();
            mockRepo.Setup(repo => repo.GetAlunoById(2));

            // Act
            var result = mockRepo.Object.GetAlunoById(2);

            // Assert
            Assert.NotNull(result);            
        }


        [Test]
        public void GetAlunoByCursoId_DeveRetornarListadeAlunoPorCursoId()
        {
            // Arrange
            var mockRepo = new Mock<IReadAlunoRepository>();
            mockRepo.Setup(repo => repo.GetAlunoByCursoId(1));

            // Act
            var result = mockRepo.Object.GetAlunoByCursoId(1);

            // Assert
            Assert.NotNull(result);
        }

        private IEnumerable<AlunoDTO> GetExampleAlunos()
        {
            return new List<AlunoDTO>
        {
            new AlunoDTO { AlunoId = 1, NomeAluno = "João Silva" },
            new AlunoDTO { AlunoId = 2, NomeAluno = "Maria Oliveira" },
            new AlunoDTO { AlunoId = 3, NomeAluno = "Salatiel Marinho" }
        };
        }
    }
}