USE BD_FAZENDA;

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Usuarios')
BEGIN
    PRINT 'A tabela já existe.'
END
ELSE
BEGIN
	-- Criação da tabela Usuarios
	CREATE TABLE Usuarios (
		Id INT PRIMARY KEY IDENTITY(1,1),
		Nome NVARCHAR(100) NOT NULL,
		Cep NVARCHAR(15) NOT NULL,
		Endereco NVARCHAR(100) NOT NULL,
		Complemento NVARCHAR(50) NOT NULL,
		Numero NVARCHAR(10) NOT NULL,
		Bairro NVARCHAR(100) NOT NULL,
		UF NVARCHAR(2) NOT NULL,		
		Email NVARCHAR(100) NOT NULL UNIQUE,
		Senha VARBINARY(MAX) NOT NULL,
		DataCriacao DATETIME DEFAULT GETDATE()
	);
	PRINT 'Tabela criada com sucesso.'
END