using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Teste_Unitario
{
    [TestClass]
    public class AlunoServiceTests
    {
        private readonly IAlunoService _alunoService;

        public AlunoServiceTests(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [TestMethod]
        [Fact]
        public void InserirAluno_DeveInserirAluno()
        {
            // Arrange
            var aluno = new Aluno
            {
                Nome = "João Marinho",
                Idade = 40,
                Curso = "ANÁLISE E DESENVOLVIMENTO DE SISTEMAS",
                Email = "joao.marinho@gmail.com",
                Endereco = "Rua Francisco Xavier, 50",
                Telefone = "(11)98855-4646"
            };

            // Act
            _alunoService.InserirAluno(aluno);
            var alunos = _alunoService.ConsultarAluno(5);

            // Assert
            Xunit.Assert.NotNull(alunos);
            Xunit.Assert.Equal(5, alunos.Count);
        }
    }
}