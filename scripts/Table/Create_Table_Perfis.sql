USE POOII;

-- Verifica se a tabela existe na base de dados
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
               WHERE TABLE_SCHEMA = 'dbo' 
               AND  TABLE_NAME = 'Perfis')
			   
	--Criação da tabela Perfis
	CREATE TABLE Perfis (
		PerfilID INT PRIMARY KEY IDENTITY(1,1),
		NomePerfil NVARCHAR(50) NOT NULL
	);
END