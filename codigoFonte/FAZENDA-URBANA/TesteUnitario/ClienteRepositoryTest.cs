using Domain.Entities;
using Moq;
using Repository.Repository;
using System.Data;
using Util.BD;

namespace TesteUnitario
{
    [TestClass]
    public class ClienteRepositoryTest
    {
        private readonly Mock<IDbConnection> _mockConnection;
        private readonly Mock<SqlFactory> _mockFactory;
        private readonly ClienteRepository _repository;

        public ClienteRepositoryTest()
        {
            _mockConnection = new Mock<IDbConnection>();
            _mockFactory = new Mock<SqlFactory>();
            _mockFactory.Setup(f => f.SqlConnection()).Returns(_mockConnection.Object);
            _repository = new ClienteRepository(_mockFactory.Object);
        }

        [TestMethod]
        public void IncluirCliente_DeveRetornarTrue_QuandoClienteIncluidoComSucesso()
        {
            // Arrange
            var cliente = new ClienteEntitie { NomeCliente = "Teste", Cpf = "123.456.789-00", Email = "email@exemplo.com", Senha = new byte[10] };
            var mockCommand = new Mock<IDbCommand>();
            mockCommand.Setup(m => m.ExecuteNonQuery()).Returns(1);
            _mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = _repository.IncluirCliente(cliente);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
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
            mockReader.Setup(m => m["NomeCliente"]).Returns("Teste");
            mockReader.Setup(m => m["Cpf"]).Returns("123.456.789-00");
            mockReader.Setup(m => m["Email"]).Returns("email@exemplo.com");
            mockCommand.Setup(m => m.ExecuteReader()).Returns(mockReader.Object);
            _mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = _repository.ConsultarCliente(nomeCliente);

            // Assert            
            Assert.Equals("Teste", result[0].NomeCliente);
        }

        [TestMethod]
        public void AlterarCliente_DeveRetornarTrue_QuandoClienteAlteradoComSucesso()
        {
            // Arrange
            var cliente = new ClienteEntitie { Id = 1, NomeCliente = "Teste Alterado" };
            var mockCommand = new Mock<IDbCommand>();
            mockCommand.Setup(m => m.ExecuteNonQuery()).Returns(1);
            _mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = _repository.AlterarCliente(cliente);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ExcluirCliente_DeveRetornarTrue_QuandoClienteExcluidoComSucesso()
        {
            // Arrange
            var id = 1;
            var mockCommand = new Mock<IDbCommand>();
            mockCommand.Setup(m => m.ExecuteNonQuery()).Returns(1);
            _mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = _repository.ExcluirCliente(id);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ExcluirCliente_DeveRetornarFalse_QuandoClienteNaoExcluido()
        {
            // Arrange
            var id = 1;
            var mockCommand = new Mock<IDbCommand>();
            mockCommand.Setup(m => m.ExecuteNonQuery()).Returns(0);
            _mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);

            // Act
            var result = _repository.ExcluirCliente(id);

            // Assert
            Assert.IsFalse(result);
        }
    }
}