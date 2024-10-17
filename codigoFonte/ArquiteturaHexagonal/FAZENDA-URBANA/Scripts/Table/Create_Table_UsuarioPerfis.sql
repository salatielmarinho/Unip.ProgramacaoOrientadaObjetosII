USE BD_FAZENDA;

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'UsuarioPerfis')
BEGIN
    PRINT 'A tabela já existe.'
END
ELSE
BEGIN
	--Criação da tabela UsuáriosPerfis
	CREATE TABLE UsuarioPerfis (
		UsuarioID INT NOT NULL,
		PerfilID INT NOT NULL,
		PRIMARY KEY (UsuarioID, PerfilID),
		FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
		FOREIGN KEY (PerfilID) REFERENCES Perfis(PerfilID)
	);
	PRINT 'Tabela criada com sucesso.'
END