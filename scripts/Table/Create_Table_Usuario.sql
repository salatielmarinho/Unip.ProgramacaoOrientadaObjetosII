USE POOII;

-- Verifica se a tabela existe na base de dados
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
               WHERE TABLE_SCHEMA = 'dbo' 
               AND  TABLE_NAME = 'Usuario')
			   
	-- Criação da tabela Usuario
	CREATE TABLE Usuario (
		UsuarioID INT PRIMARY KEY IDENTITY(1,1),
		Nome NVARCHAR(100) NOT NULL,
		Email NVARCHAR(100) NOT NULL UNIQUE,
		Senha NVARCHAR(100) NOT NULL,
		DataCriacao DATETIME DEFAULT GETDATE()
	);
END