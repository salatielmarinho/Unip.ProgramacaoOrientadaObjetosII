using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Moq;
using System.Data;
using Xunit;

namespace UnitTest.CleanArchitecture
{
    public class AlunoRepositoryTests
    {
        [Fact]
        public void InserirAluno_ValidAluno_ReturnsTrue()
        {
            // Arrange
            var aluno = new Aluno
            {
                Nome = "João Marinho",
                DataNascimento = new DateOnly(2000, 1, 1),
                FkCurso = 101
            };

            var mockFactory = new Mock<SqlFactory>();
            var mockConnection = new Mock<IDbConnection>();
            var mockCommand = new Mock<IDbCommand>();

            mockFactory.Setup(f => f.SqlConnection()).Returns(mockConnection.Object);
            mockConnection.Setup(c => c.CreateCommand()).Returns(mockCommand.Object);
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(1);

            var repository = new AlunoRepository(mockFactory.Object);

            // Act
            var result = repository.InserirAluno(aluno);

            // Assert
            Xunit.Assert.True(result);
        }

        [Fact]
        public void InserirAluno_InvalidAluno_ReturnsFalse()
        {
            // Arrange
            var aluno = new Aluno
            {
                Nome = "João Marinho",
                DataNascimento = new DateOnly(2000, 1, 1),
                Id = 102
            };

            var mockFactory = new Mock<SqlFactory>();
            var mockConnection = new Mock<IDbConnection>();
            var mockCommand = new Mock<IDbCommand>();

            mockFactory.Setup(f => f.SqlConnection()).Returns(mockConnection.Object);
            mockConnection.Setup(c => c.CreateCommand()).Returns(mockCommand.Object);
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(0);

            var repository = new AlunoRepository(mockFactory.Object);

            // Act
            var result = repository.InserirAluno(aluno);

            // Assert
            Xunit.Assert.False(result);
        }

        [Fact]
        public void ConsultarAluno_ReturnsListOfAlunos()
        {
            // Arrange
            var mockFactory = new Mock<SqlFactory>();
            var mockConnection = new Mock<IDbConnection>();
            var mockCommand = new Mock<IDbCommand>();
            var mockDataReader = new Mock<IDataReader>();

            // Setup the mock data reader to return a row
            mockDataReader.SetupSequence(reader => reader.Read())
                          .Returns(true)
                          .Returns(false); // First call returns a row, second returns no more rows

            mockDataReader.Setup(reader => reader["AlunoID"]).Returns(1);
            mockDataReader.Setup(reader => reader["NomeAluno"]).Returns("Joao Marinho");
            mockDataReader.Setup(reader => reader["DataNascimento"]).Returns(new DateOnly(2000, 1, 1));
            mockDataReader.Setup(reader => reader["CursoID"]).Returns(101);

            mockCommand.Setup(cmd => cmd.ExecuteReader()).Returns(mockDataReader.Object);
            mockConnection.Setup(conn => conn.CreateCommand()).Returns(mockCommand.Object);
            mockFactory.Setup(f => f.SqlConnection()).Returns(mockConnection.Object);

            var repository = new AlunoRepository(mockFactory.Object);

            // Act
            var result = repository.ConsultarAluno();

            // Assert
            Xunit.Assert.Single(result);
            var aluno = result[0];
            Xunit.Assert.Equal(1, aluno.Id);
            Xunit.Assert.Equal("John Doe", aluno.Nome);
            Xunit.Assert.Equal(new DateOnly(2000, 1, 1), aluno.DataNascimento);
            Xunit.Assert.Equal(101, aluno.FkCurso);
        }

        [Fact]
        public void AlterarAluno_ValidAluno_ReturnsTrue()
        {
            // Arrange
            var aluno = new Aluno
            {
                Id = 1,
                Nome = "João Marinho",
                DataNascimento = new DateOnly(2000, 1, 1)
            };

            var mockFactory = new Mock<SqlFactory>();
            var mockConnection = new Mock<IDbConnection>();
            mockFactory.Setup(f => f.SqlConnection()).Returns(mockConnection.Object);

            var mockCommand = new Mock<IDbCommand>();
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(1);
            mockConnection.Setup(c => c.CreateCommand()).Returns(mockCommand.Object);

            var repository = new AlunoRepository(mockFactory.Object);

            // Act
            var result = repository.AlterarAluno(aluno);

            // Assert
            Xunit.Assert.True(result);
        }

        [Fact]
        public void AlterarAluno_InvalidAluno_ReturnsFalse()
        {
            // Arrange
            var aluno = new Aluno
            {
                Id = 1,
                Nome = "João Marinho",
                DataNascimento = new DateOnly(2000, 1, 1)
            };

            var mockFactory = new Mock<SqlFactory>();
            var mockConnection = new Mock<IDbConnection>();
            mockFactory.Setup(f => f.SqlConnection()).Returns(mockConnection.Object);

            var mockCommand = new Mock<IDbCommand>();
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(0);
            mockConnection.Setup(c => c.CreateCommand()).Returns(mockCommand.Object);

            var repository = new AlunoRepository(mockFactory.Object);

            // Act
            var result = repository.AlterarAluno(aluno);

            // Assert
            Xunit.Assert.False(result);
        }

        [Fact]
        public void ExcluirAluno_ValidId_ReturnsTrue()
        {
            // Arrange
            var id = 1;

            var mockFactory = new Mock<SqlFactory>();
            var mockConnection = new Mock<IDbConnection>();
            var mockCommand = new Mock<IDbCommand>();

            mockFactory.Setup(f => f.SqlConnection()).Returns(mockConnection.Object);
            mockConnection.Setup(c => c.CreateCommand()).Returns(mockCommand.Object);
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(1);

            var repository = new AlunoRepository(mockFactory.Object);

            // Act
            var result = repository.ExcluirAluno(id);

            // Assert
            Xunit.Assert.True(result);
        }

        [Fact]
        public void ExcluirAluno_InvalidId_ReturnsFalse()
        {
            // Arrange
            var id = 999; // Assume this ID does not exist

            var mockFactory = new Mock<SqlFactory>();
            var mockConnection = new Mock<IDbConnection>();
            var mockCommand = new Mock<IDbCommand>();

            mockFactory.Setup(f => f.SqlConnection()).Returns(mockConnection.Object);
            mockConnection.Setup(c => c.CreateCommand()).Returns(mockCommand.Object);
            mockCommand.Setup(cmd => cmd.ExecuteNonQuery()).Returns(0);

            var repository = new AlunoRepository(mockFactory.Object);

            // Act
            var result = repository.ExcluirAluno(id);

            // Assert
            Xunit.Assert.False(result);
        }
    }
}