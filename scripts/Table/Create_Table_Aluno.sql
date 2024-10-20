USE POOII;

-- Verifica se a tabela existe na base de dados
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
               WHERE TABLE_SCHEMA = 'dbo' 
               AND  TABLE_NAME = 'Aluno')
BEGIN
	-- Criação da tabela Aluno
	CREATE TABLE Aluno (
		Id INT IDENTITY(1,1) PRIMARY KEY,
		Nome NVARCHAR(100) NOT NULL,
		DataNascimento DATE,
		FKCurso INT,
		Status BIT DEFAULT 1,
		DataCriacao DATETIME DEFAULT GETDATE()
		FOREIGN KEY (FKCurso) REFERENCES Curso(Id)
	);
END