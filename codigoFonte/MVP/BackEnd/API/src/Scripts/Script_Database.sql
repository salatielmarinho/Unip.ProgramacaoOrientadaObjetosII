-------------------------------------------------------------------------
--					CRIAR BASE DE DADOS                               ---
-------------------------------------------------------------------------

-- Verificar se o banco de dados existe
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'MVP')
BEGIN
    -- Criar o banco de dados
    CREATE DATABASE MVP;
    PRINT 'Banco de dados criado com sucesso.';
END
ELSE
BEGIN
    PRINT 'O banco de dados já existe.';
END