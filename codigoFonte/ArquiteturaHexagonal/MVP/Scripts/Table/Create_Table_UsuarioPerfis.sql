USE PIM;

--Criação da tabela UsuáriosPerfis
CREATE TABLE UsuarioPerfis (
    UsuarioID INT NOT NULL,
    PerfilID INT NOT NULL,
    PRIMARY KEY (UsuarioID, PerfilID),
    FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
    FOREIGN KEY (PerfilID) REFERENCES Perfis(PerfilID)
);