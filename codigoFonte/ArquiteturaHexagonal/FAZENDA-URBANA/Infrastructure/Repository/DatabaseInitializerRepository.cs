using Infrastructure.Factory;
using Infrastructure.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Repository.Repository
{
    public class DatabaseInitializerRepository : IDatabaseInitializerRepository
    {
        #region Propriedades        
        private readonly IDbConnection _connection;
        #endregion

        #region Construtor
        public DatabaseInitializerRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
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
                IF EXISTS (SELECT * FROM sys.databases WHERE name = 'BD_FAZENDA')
                    BEGIN
                        PRINT 'O banco de dados existe.'
                    END
                ELSE
	                BEGIN
		                CREATE DATABASE BD_FAZENDA;
		                PRINT 'Banco de dados criado com sucesso.'
	                END;";
                ExecuteNonQuery(dataBase);
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
            CreateProcedureConsultarCliente();
            CreateProcedureExcluirCliente();
            CreateProcedureInserirCliente();

            //Perfil
            CreateProcedureAlterarPerfil();
            CreateProcedureConsultarPerfil();
            CreateProcedureConsultarTodosPerfis();
            CreateProcedureExcluirPerfil();
            CreateProcedureInserirPerfil();

            //Usuário
            CreateProcedureAlterarUsuario();
            CreateProcedureConsultarUsuario();
            CreateProcedureConsultarPerfilUsuario();
            CreateProcedureExcluirUsuario();
            CreateProcedureInserirUsuario();
        }
        private void InitializeCarga()
        {
            CargaInicial();
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
            ExecuteNonQuery(tableCliente);
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
            ExecuteNonQuery(tablePerfil);
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
            ExecuteNonQuery(tableUsuario);
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
            ExecuteNonQuery(tableFornecedor);
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
            ExecuteNonQuery(tableProduto);
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
            ExecuteNonQuery(tableVenda);
        }
        #endregion

        #region Procedures Cliente       
        private void CreateProcedureAlterarCliente()
        {
            string procedureAlterarCliente = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'AlterarCliente' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarCliente')
	            BEGIN
		            DROP PROCEDURE InserirCliente;
	            END
            GO
                BEGIN
                    -- Cria a procedure 'AlterarCliente'
                    CREATE PROCEDURE AlterarCliente
                        @NomeCliente VARCHAR(100),
                        @Id INT    
                    AS
                    BEGIN
	                    UPDATE Cliente
	                    SET NomeCliente = @NomeCliente
		                    WHERE Id = @Id
                    END;
                END";
            ExecuteNonQuery(procedureAlterarCliente);
        }
        private void CreateProcedureConsultarCliente()
        {
            string procedureConsultarCliente = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'ConsultarCliente' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarCliente')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
                    -- Cria a procedure 'ConsultarCliente'
                    CREATE PROCEDURE ConsultarCliente
                        @NomeCliente VARCHAR(15)
                    AS
                    BEGIN
                        SELECT Id, NomeCliente, CPF, Email, DataCriacao
                        FROM Cliente WITH(NOLOCK)
                        WHERE NomeCliente LIKE '%' + @NomeCliente + '%'
	                    AND Ativo = 1
                    END;
                END";
            ExecuteNonQuery(procedureConsultarCliente);
        }
        private void CreateProcedureExcluirCliente()
        {
            string procedureExcluirCliente = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'ExcluirCliente' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirCliente')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
                    -- Cria a procedure 'ExcluirCliente'
                    CREATE PROCEDURE ExcluirCliente    
                        @Id INT    
                    AS
                    BEGIN
	                    UPDATE Cliente
		                    SET Ativo = 0
		                    WHERE Id = @Id
                    END;
                END";
            ExecuteNonQuery(procedureExcluirCliente);
        }
        private void CreateProcedureInserirCliente()
        {
            string procedureInserirCliente = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'InserirCliente' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InserirCliente')
	            BEGIN
		            DROP PROCEDURE InserirCliente;
	            END                            
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
                END";
            ExecuteNonQuery(procedureInserirCliente);
        }
        #endregion

        #region Procedures Perfil       
        private void CreateProcedureAlterarPerfil()
        {
            string procedureAlterarPerfil = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'AlterarPerfil' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarPerfil')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
                    -- Cria a procedure 'AlterarPerfil'
                    CREATE PROCEDURE AlterarPerfil
                        @NomePerfil NVARCHAR(50),
                        @Id INT    
                    AS
                    BEGIN
	                    UPDATE Perfil
	                    SET NomePerfil = @NomePerfil
		                    WHERE Id = @Id
                    END;
                END";
            ExecuteNonQuery(procedureAlterarPerfil);
        }
        private void CreateProcedureConsultarPerfil()
        {
            string procedureConsultarPerfil = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'ConsultarPerfil' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarPerfil')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
                    -- Cria a procedure 'ConsultarPerfil'
                    CREATE PROCEDURE ConsultarPerfil
                        @NomePerfil NVARCHAR(50)
                    AS
                    BEGIN
                        SELECT Id, NomePerfil, DataCriacao
                        FROM Perfil WITH(NOLOCK)
                        WHERE NomePerfil LIKE '%' + @NomePerfil + '%'
	                    AND Ativo = 1
                    END;
                END";
            ExecuteNonQuery(procedureConsultarPerfil);
        }
        private void CreateProcedureConsultarTodosPerfis()
        {
            string procedureConsultarTodosPerfis = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'ConsultarTodosPerfis' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarTodosPerfis')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
                    -- Cria a procedure 'ConsultarTodosPerfis'
                    CREATE PROCEDURE ConsultarTodosPerfis    
                    AS
                    BEGIN
                        SELECT Id, NomePerfil
                        FROM Perfil WITH(NOLOCK)
                        WHERE Ativo = 1
                    END;
                END;";
            ExecuteNonQuery(procedureConsultarTodosPerfis);
        }
        private void CreateProcedureExcluirPerfil()
        {
            string procedureExcluirPerfil = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'ExcluirPerfil' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirPerfil')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
                    -- Cria a procedure 'ExcluirPerfil'
                    CREATE PROCEDURE ExcluirPerfil    
                        @Id INT    
                    AS
                    BEGIN
	                    UPDATE Perfil
		                    SET Ativo = 0
		                    WHERE Id = @Id
                    END;
                END";
            ExecuteNonQuery(procedureExcluirPerfil);
        }
        private void CreateProcedureInserirPerfil()
        {
            string procedureInserirPerfil = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'ExcluirPerfil' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InserirPerfil')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
		            -- Cria a procedure 'InserirPerfil'
		            CREATE PROCEDURE InserirPerfil
			            @NomePerfil NVARCHAR(50)      
		            AS
		            BEGIN
			            -- Verifica se o perfil já existe
			            IF EXISTS (SELECT 1 FROM Perfil WHERE NomePerfil = @NomePerfil)
				            BEGIN
					            -- Se o perfil já existe, retorna uma mensagem
					            PRINT 'Perfil já existe.'
				            END;
			            ELSE
				            BEGIN
					            INSERT INTO Perfil (NomePerfil)
					            VALUES (@NomePerfil);
				            END;
		            END;
	            END;";
            ExecuteNonQuery(procedureInserirPerfil);
        }
        #endregion

        #region Procedures Usuário       
        private void CreateProcedureAlterarUsuario()
        {
            string procedureAlterarUsuario = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'AlterarUsuario' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarUsuario')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
                    -- Cria a procedure 'AlterarUsuario'
                    CREATE PROCEDURE AlterarUsuario
                        @Nome NVARCHAR(100),
                        @Id INT    
                    AS
                    BEGIN
	                    UPDATE Usuario
	                    SET Nome = @Nome
		                    WHERE Id = @Id
                    END;";
            ExecuteNonQuery(procedureAlterarUsuario);
        }
        private void CreateProcedureConsultarUsuario()
        {
            string procedureConsultarUsuario = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'ConsultarUsuario' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarUsuario')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
                    -- Cria a procedure 'ConsultarUsuario'
                    CREATE PROCEDURE ConsultarUsuario
                        @NomeUsuario NVARCHAR(50)
                    AS
                    BEGIN
                        SELECT usr.Id, per.NomePerfil, usr.Nome, usr.Cep, usr.Endereco, usr.Complemento,
	                    usr.Numero, usr.Bairro, usr.UF, usr.Email, usr.DataCriacao
                        FROM Usuario AS usr
	                    INNER JOIN Perfil AS per
	                    ON usr.Fk_Perfil = per.Id
                        WHERE usr.Nome LIKE '%' + @NomeUsuario + '%'
	                    AND usr.Ativo = 1
                    END;";
            ExecuteNonQuery(procedureConsultarUsuario);
        }
        private void CreateProcedureConsultarPerfilUsuario()
        {
            string procedureConsultarPerfilUsuario = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'ConsultarPerfilUsuario' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarPerfilUsuario')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
                    -- Cria a procedure 'ConsultarPerfilUsuario'
                    CREATE PROCEDURE ConsultarPerfilUsuario
                        @NomeUsuario NVARCHAR(50),
	                    @Senha NVARCHAR(20)
                    AS
                    BEGIN
                        SELECT usr.FK_Perfil
                        FROM Usuario AS usr
	                    INNER JOIN Perfil AS per
	                    ON usr.Fk_Perfil = per.Id
                        WHERE usr.Nome LIKE '%' + @NomeUsuario + '%'
		                      AND usr.Senha = @Senha
		                      AND per.Ativo = 1
		                      AND usr.Ativo = 1
                    END;";
            ExecuteNonQuery(procedureConsultarPerfilUsuario);
        }
        private void CreateProcedureExcluirUsuario()
        {
            string procedureExcluirCliente = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'ExcluirUsuario' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirUsuario')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
                    -- Cria a procedure 'ExcluirUsuario'
                    CREATE PROCEDURE ExcluirUsuario    
                        @Id INT    
                    AS
                    BEGIN
	                    UPDATE Usuario
		                    SET Ativo = 0
		                    WHERE Id = @Id
                    END;
                END";
            ExecuteNonQuery(procedureExcluirCliente);
        }
        private void CreateProcedureInserirUsuario()
        {
            string procedureInserirUsuario = @"USE BD_FAZENDA;
            -- Verifica se a procedure 'InserirUsuario' existe e a exclui se existir
            IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InserirUsuario')
	            BEGIN
		            PRINT 'A stored procedure existe.'
	            END
            ELSE
                BEGIN
                    -- Cria a procedure 'InserirUsuario'
                    CREATE PROCEDURE InserirUsuario
                        @Fk_Perfil INT,
	                    @Nome NVARCHAR(100),
	                    @Cep NVARCHAR(15),
	                    @Endereco NVARCHAR(100),
	                    @Complemento NVARCHAR(50),
	                    @Numero NVARCHAR(10),
	                    @Bairro NVARCHAR(100),
	                    @Uf NVARCHAR(2),
	                    @Email NVARCHAR(100),
	                    @Senha NVARCHAR(20)
                    AS
                    BEGIN
                        -- Verifica se pessoa já existe
                        IF EXISTS (SELECT 1 FROM Usuario WHERE Nome = @Nome)
                        BEGIN
                            -- Se pessoa já existe, retorna uma mensagem
                            PRINT 'Usuário(a) já existe.'
                        END
                        ELSE
		                    BEGIN
			                    INSERT INTO Usuario (Fk_Perfil, Nome, Cep, Endereco, Complemento, Numero, Bairro,
			                    UF, Email, Senha)
			                    VALUES (@Fk_Perfil, @Nome, @Cep, @Endereco, @Complemento, @Numero, @Bairro,
			                    @Uf, @Email, @Senha);
		                    END;
                    END;
                END";
            ExecuteNonQuery(procedureInserirUsuario);
        }
        #endregion

        #region CargaInicial
        private void CargaInicial()
        {
            string scriptCargaInicial = @"USE BD_FAZENDA;
            INSERT INTO [dbo].[Perfil]
                       ([NomePerfil]
                       ,[Ativo]
                       ,[DataCriacao])
                 VALUES
                       ('Admin'
                       ,1
                       ,GETDATE())            

            INSERT INTO [dbo].[Perfil]
                       ([NomePerfil]
                       ,[Ativo]
                       ,[DataCriacao])
                 VALUES
                       ('Usuario'
                       ,2
                       ,GETDATE())            

            INSERT INTO [dbo].[Usuario]
                       ([Fk_Perfil]
                       ,[Nome]
                       ,[Cep]
                       ,[Endereco]
                       ,[Complemento]
                       ,[Numero]
                       ,[Bairro]
                       ,[UF]
                       ,[Email]
                       ,[Senha]
                       ,[Ativo]
                       ,[DataCriacao])
                 VALUES
                       (1
                       ,'admin'
                       ,'08240-270'
                       ,'Rua Unip'
                       ,'Unip'
                       ,'1'
                       ,'São Paulo'
                       ,'SP'
                       ,'admin@unip.br'
                       ,'ef797c8118f02dfb6496'
                       ,1
                       ,GETDATE())
            ";
            ExecuteNonQuery(scriptCargaInicial);
        }
        #endregion

        #region Métodos
        private void ExecuteNonQuery(string script)
        {
            try
            {
                _connection.Open();
                using (SqlCommand command = new SqlCommand(script, (SqlConnection)_connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion
    }
}