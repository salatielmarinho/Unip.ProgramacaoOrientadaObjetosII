using Infrastructure.Configuration;
using Infrastructure.Interfaces;

namespace Infrastructure.Data
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        #region Propriedades        
        private readonly RepositoryConfiguration _configuration;
        #endregion

        #region Construtor
        public DatabaseInitializer(RepositoryConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        public void Initializer()
        {
            InitializeDatabase();
            InitializeTable();
            InitializeProcedure();
            InitializeCarga();
        }

        #region Setup
        private void InitializeDatabase()
        {
            try
            {
                //Criar Base de Dados
                string dataBase = @"
                IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'BD_FAZENDA')
                BEGIN
                    PRINT 'O banco de dados já existe.'
                END
                ELSE
                BEGIN
                    CREATE DATABASE BD_FAZENDA;
                    PRINT 'Banco de dados criado com sucesso.'
                END";
                _configuration.dDatabaseInitializerRepository.ExecuteNonQuery(dataBase);
            }
            catch
            {
                throw;
            }
        }
        private void InitializeTable()
        {
            CreateTableCliente();
            CreateTablePerfil();
            CreateTableUsuario();
            CreateTableFornecedor();
            CreateTableProduto();
            CreateTableVenda();
        }
        private void InitializeProcedure()
        {
            //Cliente
            CreateProcedureInserirCliente();
        }
        private void InitializeCarga()
        {

        }

        #endregion       

        #region Table
        private void CreateTableCliente()
        {
            string tableCliente = @"USE BD_FAZENDA;
            IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Cliente')
            BEGIN
                PRINT 'A tabela já existe.'
            END
            ELSE
            BEGIN
	            CREATE TABLE Cliente 
	            (
		              Id INT NOT NULL PRIMARY KEY IDENTITY,
		              NomeCliente VARCHAR(100) NOT NULL,
		              CPF VARCHAR(15) NOT NULL,
		              Email VARCHAR(50) NOT NULL,
		              Ativo BIT DEFAULT 1,
		              DataCriacao DATETIME DEFAULT GETDATE()
	            );
	            PRINT 'Tabela criada com sucesso.'
            END";
            _configuration.dDatabaseInitializerRepository.ExecuteNonQuery(tableCliente);
        }
        private void CreateTablePerfil()
        {
            string tablePerfil = @"USE BD_FAZENDA;
            IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Perfil')
            BEGIN
                PRINT 'A tabela já existe.'
            END
            ELSE
            BEGIN
	            --Criação da tabela Perfil
	            CREATE TABLE Perfil (
		            Id INT PRIMARY KEY IDENTITY(1,1),
		            NomePerfil NVARCHAR(50) NOT NULL,
		            Ativo BIT DEFAULT 1,
		            DataCriacao DATETIME DEFAULT GETDATE()
	            );
	            PRINT 'Tabela criada com sucesso.'
            END";
            _configuration.dDatabaseInitializerRepository.ExecuteNonQuery(tablePerfil);
        }
        private void CreateTableUsuario()
        {
            string tableUsuario = @"USE BD_FAZENDA;
            IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Usuario')
            BEGIN
                PRINT 'A tabela já existe.'
            END
            ELSE
            BEGIN
	            -- Criação da tabela Usuario
	            CREATE TABLE Usuario (
		            Id INT PRIMARY KEY IDENTITY(1,1),
		            Fk_Perfil INT NOT NULL,
		            Nome NVARCHAR(100) NOT NULL,
		            Cep NVARCHAR(15) NOT NULL,
		            Endereco NVARCHAR(100) NOT NULL,
		            Complemento NVARCHAR(50) NOT NULL,
		            Numero NVARCHAR(10) NOT NULL,
		            Bairro NVARCHAR(100) NOT NULL,
		            UF NVARCHAR(2) NOT NULL,		
		            Email NVARCHAR(100) NOT NULL UNIQUE,
		            Senha NVARCHAR(20) NOT NULL,
		            Ativo BIT DEFAULT 1,
		            DataCriacao DATETIME DEFAULT GETDATE()
		            CONSTRAINT FK_Perfil FOREIGN KEY (Id)
	                REFERENCES Perfil(Id)		
	            );
	            PRINT 'Tabela criada com sucesso.'
            END";
            _configuration.dDatabaseInitializerRepository.ExecuteNonQuery(tableUsuario);
        }
        private void CreateTableFornecedor()
        {
            string tableFornecedor = @"USE BD_FAZENDA;
            IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Fornecedor')
            BEGIN
                PRINT 'A tabela já existe.'
            END
            ELSE
            BEGIN
	            CREATE TABLE Fornecedor 
	            (
		              Id INT NOT NULL PRIMARY KEY IDENTITY,
		              NomeEmpresa VARCHAR(50) NOT NULL,
		              CNPJ VARCHAR(20) NOT NULL,
		              Adubo VARCHAR(30) NOT NULL,
		              QuantidadeAdubo INT NOT NULL,
		              Agrotoxico VARCHAR(30) NOT NULL,
		              QuantidadeAgrotoxico INT NOT NULL,
		              Muda VARCHAR(30) NOT NULL,
		              QuantidadeMuda INT NOT NULL,
		              Status BIT DEFAULT 1,
		              DataCriacao DATETIME DEFAULT GETDATE()
	            );
	            PRINT 'Tabela criada com sucesso.'
            END";
            _configuration.dDatabaseInitializerRepository.ExecuteNonQuery(tableFornecedor);
        }
        private void CreateTableProduto()
        {
            string tableProduto = @"USE BD_FAZENDA;
            IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Produto')
            BEGIN
                PRINT 'A tabela já existe.'
            END
            ELSE
            BEGIN
	            CREATE TABLE Produto
	            (
		            Id INT NOT NULL PRIMARY KEY IDENTITY,
		            Produto VARCHAR(50) NOT NULL,
		            Quantidade INT NOT NULL,
		            Preco DECIMAL(10, 2) NOT NULL,
		            Status BIT DEFAULT 1,
		            DataCriacao DATETIME DEFAULT GETDATE()
	            );
	            PRINT 'Tabela criada com sucesso.'
            END";
            _configuration.dDatabaseInitializerRepository.ExecuteNonQuery(tableProduto);
        }
        private void CreateTableVenda()
        {
            string tableVenda = @"USE BD_FAZENDA;
            IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Venda')
            BEGIN
                PRINT 'A tabela já existe.'
            END
            ELSE
            BEGIN
	            CREATE TABLE Venda
	            (
		            Id INT NOT NULL PRIMARY KEY IDENTITY,
		            Produto VARCHAR(30) NOT NULL,
		            QuantidadeVendida VARCHAR(15) NOT NULL,
		            ValorTotal DECIMAL(10, 2) NOT NULL,
		            FormaDePagamento VARCHAR(50) NOT NULL,
		            Status BIT DEFAULT 1,
		            DataCriacao DATETIME DEFAULT GETDATE()
	            );
	            PRINT 'Tabela criada com sucesso.'
            END";
            _configuration.dDatabaseInitializerRepository.ExecuteNonQuery(tableVenda);
        }
        #endregion

        #region Procedures
        private void CreateProcedureInserirCliente()
        {
            string procedureInserirCliente = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'InserirCliente' existe e a exclui se existir
            IF OBJECT_ID('InserirCliente', 'P') IS NOT NULL
                DROP PROCEDURE InserirCliente;
            GO

            -- Cria a procedure 'InserirCliente'
            CREATE PROCEDURE InserirCliente
                @NomeCliente VARCHAR(100),    
                @Cpf VARCHAR(15),
                @Email VARCHAR(50)    
            AS
            BEGIN
                -- Verifica se o cliente já existe
                IF EXISTS (SELECT 1 FROM Cliente WHERE Cpf = @Cpf)
                BEGIN
                    -- Se o cliente já existe, retorna uma mensagem
                    PRINT 'Cliente já existe.'
                END
                ELSE
		            BEGIN
			            INSERT INTO Cliente (NomeCliente, CPF, Email)
			            VALUES (@NomeCliente, @Cpf, @Email);
		            END;
            END;";
            _configuration.dDatabaseInitializerRepository.ExecuteNonQuery(procedureInserirCliente);
        }
        #endregion

        #region CargaInicial

        #endregion
    }
}
