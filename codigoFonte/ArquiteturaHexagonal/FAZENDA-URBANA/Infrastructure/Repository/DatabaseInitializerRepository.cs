﻿using Infrastructure.Factory;
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
                string fileName = "Create_Db_Fazenda.sql";
                string relativePath = Path.Combine("Scripts", "1. DataBase", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
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
            //Drop Procedure
            DropProcedure();

            //Cliente
            CreateProcedureAlterarCliente();
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
            try
            {
                string fileName = "1. Create_Table_Cliente.sql";
                string relativePath = Path.Combine("Scripts", "2. Table", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateTablePerfil()
        {
            try
            {
                string fileName = "2. Create_Table_Perfil.sql";
                string relativePath = Path.Combine("Scripts", "2. Table", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateTableUsuario()
        {
            try
            {
                string fileName = "3. Create_Table_Usuario.sql";
                string relativePath = Path.Combine("Scripts", "2. Table", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateTableFornecedor()
        {
            try
            {
                string fileName = "4. Create_Table_Fornecedor.sql";
                string relativePath = Path.Combine("Scripts", "2. Table", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateTableProduto()
        {
            try
            {
                string fileName = "5. Create_Table_Produto.sql";
                string relativePath = Path.Combine("Scripts", "2. Table", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateTableVenda()
        {
            try
            {
                string fileName = "6. Create_Table_Venda.sql";
                string relativePath = Path.Combine("Scripts", "2. Table", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        #endregion
        private void DropProcedure()
        {
            try
            {
                string fileName = "ValidationProcedure.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        #region Drop Procedure

        #endregion

        #region Procedures Cliente       
        private void CreateProcedureAlterarCliente()
        {
            try
            {
                string fileName = "StoredProcedure_AlterarCliente.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "1. Cliente", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateProcedureConsultarCliente()
        {
            try
            {
                string fileName = "StoredProcedure_ConsultarCliente.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "1. Cliente", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateProcedureExcluirCliente()
        {
            try
            {
                string fileName = "StoredProcedure_ExcluirCliente.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "1. Cliente", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateProcedureInserirCliente()
        {
            try
            {
                string fileName = "StoredProcedure_InserirCliente.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "1. Cliente", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Procedures Perfil       
        private void CreateProcedureAlterarPerfil()
        {
            try
            {
                string fileName = "StoredProcedure_AlterarPerfil.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "2. Perfil", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateProcedureConsultarPerfil()
        {
            try
            {
                string fileName = "StoredProcedure_ConsultarPerfil.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "2. Perfil", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateProcedureConsultarTodosPerfis()
        {
            try
            {
                string fileName = "StoredProcedure_ConsultarTodosPerfis.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "2. Perfil", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateProcedureExcluirPerfil()
        {
            try
            {
                string fileName = "StoredProcedure_ExcluirPerfil.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "2. Perfil", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateProcedureInserirPerfil()
        {
            try
            {
                string fileName = "StoredProcedure_InserirPerfil.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "2. Perfil", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Procedures Usuário       
        private void CreateProcedureAlterarUsuario()
        {
            try
            {
                string fileName = "StoredProcedure_AlterarUsuario.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "3. Usuario", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateProcedureConsultarUsuario()
        {
            try
            {
                string fileName = "StoredProcedure_ConsultarPerfilUsuario.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "3. Usuario", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateProcedureConsultarPerfilUsuario()
        {
            try
            {
                string fileName = "StoredProcedure_ConsultarUsuario.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "3. Usuario", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateProcedureExcluirUsuario()
        {
            try
            {
                string fileName = "StoredProcedure_ExcluirUsuario.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "3. Usuario", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        private void CreateProcedureInserirUsuario()
        {
            try
            {
                string fileName = "StoredProcedure_InserirUsuario.sql";
                string relativePath = Path.Combine("Scripts", "3. StoredProcedure", "3. Usuario", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region CargaInicial
        private void CargaInicial()
        {
            try
            {
                string fileName = "CargaInicial.sql";
                string relativePath = Path.Combine("Scripts", "4. Carga", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                ExecuteNonQuery(fullPath);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Métodos
        private void ExecuteNonQuery(string script)
        {
            bool validarExistenciaDb = false;
            try
            {
                _connection.Open();
                validarExistenciaDb = ValidarExistenciaDb();
                if (validarExistenciaDb)
                {
                    _connection.ChangeDatabase("BD_FAZENDA");
                }
                else
                {
                    _connection.ChangeDatabase("MASTER");
                }
                using (SqlCommand command = new SqlCommand(File.ReadAllText(script), (SqlConnection)_connection))
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

        private bool ValidarExistenciaDb()
        {
            bool validarExistenciaDb = false;
            try
            {
                string fileName = "ValidateDb.sql";
                string relativePath = Path.Combine("Scripts", "1. DataBase", fileName);
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                using (SqlCommand command = new SqlCommand(File.ReadAllText(fullPath), (SqlConnection)_connection))
                {
                    int dbExists = (int)command.ExecuteScalar();

                    if (dbExists == 1)
                    {
                        validarExistenciaDb = true;
                    }
                }
                return validarExistenciaDb;
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}