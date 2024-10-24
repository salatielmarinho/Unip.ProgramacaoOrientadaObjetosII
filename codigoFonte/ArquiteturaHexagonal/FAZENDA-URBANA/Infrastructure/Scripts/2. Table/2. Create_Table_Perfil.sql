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
END