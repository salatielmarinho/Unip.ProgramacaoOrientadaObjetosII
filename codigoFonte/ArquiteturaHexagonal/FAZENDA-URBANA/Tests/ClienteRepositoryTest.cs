using Bogus;
using Domain.Entities;
using Infrastructure.Configuration;
using Infrastructure.Factory;
using Moq;
using System.Data;

namespace Tests
{
    public class ClienteRepositoryTest
    {
        private readonly Mock<IDbConnection>? _mockConnection;
        private readonly Mock<SqlFactory>? _mockFactory;
        private readonly RepositoryConfiguration _configuration;
        private readonly Faker? _faker;

        public ClienteRepositoryTest()
        {
            _mockConnection = new Mock<IDbConnection>();
            _mockFactory = new Mock<SqlFactory>();
            _configuration = new RepositoryConfiguration();
            _faker = new Faker();
        }

        [Fact]
        public void IncluirCliente_DeveRetornarTrue_QuandoClienteIncluidoComSucesso()
        {
            // Arrange
            var cliente = new Cliente { NomeCliente = "Teste", Cpf = "123.456.789-00", Email = _faker.Person.Email };
            var mockCommand = new Mock<IDbCommand>();
            mockCommand.Setup(m => m.ExecuteNonQuery()).Returns(1);
            _mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = _configuration.clienteRepository.IncluirCliente(cliente);

            // Assert
            Xunit.Assert.True(result);
        }

        [Fact]
        public void ConsultarCliente_DeveRetornarListaDeClientes_QuandoClientesExistem()
        {
            // Arrange
            var nomeCliente = "Teste";
            var mockCommand = new Mock<IDbCommand>();
            var mockReader = new Mock<IDataReader>();
            mockReader.SetupSequence(m => m.Read())
                      .Returns(true)
                      .Returns(false);
            mockReader.Setup(m => m["Id"]).Returns(1);
            mockReader.Setup(m => m["Cpf"]).Returns("123.456.789-00");
            mockCommand.Setup(m => m.ExecuteReader()).Returns(mockReader.Object);
            _mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = _configuration.clienteRepository.ConsultarCliente(nomeCliente);

            // Assert            
            Xunit.Assert.Equal("123.456.789-00", result[0].Cpf);
        }

        [Fact]
        public void AlterarCliente_DeveRetornarTrue_QuandoClienteAlteradoComSucesso()
        {
            // Arrange
            var cliente = new Cliente { Id = 1, NomeCliente = _faker.Person.FirstName };
            var mockCommand = new Mock<IDbCommand>();
            mockCommand.Setup(m => m.ExecuteNonQuery()).Returns(1);
            _mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = _configuration.clienteRepository.AlterarCliente(cliente);

            // Assert
            Xunit.Assert.True(result);
        }

        [Fact]
        public void ExcluirCliente_DeveRetornarTrue_QuandoClienteExcluidoComSucesso()
        {
            // Arrange
            var id = 1;
            var mockCommand = new Mock<IDbCommand>();
            mockCommand.Setup(m => m.ExecuteNonQuery()).Returns(1);
            _mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = _configuration.clienteRepository.ExcluirCliente(id);

            // Assert
            Xunit.Assert.True(result);
        }

        [Fact]
        public void ExcluirCliente_DeveRetornarFalse_QuandoClienteNaoExcluido()
        {
            // Arrange
            var id = 1;
            var mockCommand = new Mock<IDbCommand>();
            mockCommand.Setup(m => m.ExecuteNonQuery()).Returns(0);
            _mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = _configuration.clienteRepository.ExcluirCliente(id);

            // Assert
            Xunit.Assert.False(result);
        }
    }
}