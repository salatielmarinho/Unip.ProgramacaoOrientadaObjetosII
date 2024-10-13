IF EXISTS (SELECT * FROM sys.databases WHERE name = 'BD_FAZENDA')
BEGIN
    PRINT 'O banco de dados já existe.'
END
ELSE
BEGIN
    CREATE DATABASE BD_FAZENDA;
    PRINT 'Banco de dados criado com sucesso.'
END

USE BD_FAZENDA;

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
		  Senha VARCHAR(4) NOT NULL
	);
	 PRINT 'Tabela criada com sucesso.'
END

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Funcionario')
BEGIN
    PRINT 'A tabela já existe.'
END
ELSE
BEGIN
	CREATE TABLE Funcionario 
	(
		  Id INT NOT NULL PRIMARY KEY IDENTITY,
		  NomeFuncionario VARCHAR(100) NOT NULL,
		  CPF VARCHAR(15) NOT NULL,
		  Funcao VARCHAR(50) NOT NULL
	);
PRINT 'Tabela criada com sucesso.'
END

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
		  QuantidadeMuda INT NOT NULL
	);
	PRINT 'Tabela criada com sucesso.'
END

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Produtos')
BEGIN
    PRINT 'A tabela já existe.'
END
ELSE
BEGIN
	CREATE TABLE Produtos 
	(
		  Id INT NOT NULL PRIMARY KEY IDENTITY,
		  Produto VARCHAR(50) NOT NULL,
		  Quantidade INT NOT NULL,
		  Preco DECIMAL(10, 2) NOT NULL
	);
	PRINT 'Tabela criada com sucesso.'
END

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Vendas')
BEGIN
    PRINT 'A tabela já existe.'
END
ELSE
BEGIN
	CREATE TABLE Vendas 
	(
		  Id INT NOT NULL PRIMARY KEY IDENTITY,
		  Produto VARCHAR(30) NOT NULL,
		  QuantidadeVendida VARCHAR(15) NOT NULL,
		  ValorTotal DECIMAL(10, 2) NOT NULL,
		  FormaDePagamento VARCHAR(50) NOT NULL
	);
	PRINT 'Tabela criada com sucesso.'
END



