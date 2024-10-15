USE POOII;

-- Verifica se a tabela existe na base de dados
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES 
               WHERE TABLE_SCHEMA = 'dbo' 
               AND  TABLE_NAME = 'UsuarioPerfis')
			   
	--Criação da tabela UsuáriosPerfis
	CREATE TABLE UsuarioPerfis (
		UsuarioID INT NOT NULL,
		PerfilID INT NOT NULL,
		PRIMARY KEY (UsuarioID, PerfilID),
		FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
		FOREIGN KEY (PerfilID) REFERENCES Perfis(PerfilID)
	);
END