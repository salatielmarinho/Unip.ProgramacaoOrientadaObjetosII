USE PIM;

--Criação da tabela Perfis
CREATE TABLE Perfis (
    PerfilID INT PRIMARY KEY IDENTITY(1,1),
    NomePerfil NVARCHAR(50) NOT NULL
);