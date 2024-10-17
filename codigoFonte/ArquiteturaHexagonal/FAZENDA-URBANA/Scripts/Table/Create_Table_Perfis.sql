USE BD_FAZENDA;

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Perfis')
BEGIN
    PRINT 'A tabela já existe.'
END
ELSE
BEGIN
	--Criação da tabela Perfis
	CREATE TABLE Perfis (
		PerfilID INT PRIMARY KEY IDENTITY(1,1),
		NomePerfil NVARCHAR(50) NOT NULL
	);
	PRINT 'Tabela criada com sucesso.'
END