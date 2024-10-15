USE POOII;

-- Verifica se a tabela existe na base de dados
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
               WHERE TABLE_SCHEMA = 'dbo' 
               AND  TABLE_NAME = 'Curso')
BEGIN			   
	-- Criação da tabela Curso
	CREATE TABLE Curso (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Nome NVARCHAR(100) NOT NULL,
		Descricao NVARCHAR(255),
		Status BIT DEFAULT 1,
		DataCriacao DATETIME DEFAULT GETDATE()
	);
END