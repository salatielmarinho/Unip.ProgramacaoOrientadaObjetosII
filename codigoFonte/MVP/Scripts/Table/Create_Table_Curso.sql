USE PIM;

-- Criação da tabela Curso
CREATE TABLE Curso (
    CursoID INT IDENTITY(1,1) PRIMARY KEY,
    NomeCurso NVARCHAR(100) NOT NULL,
    Descricao NVARCHAR(255)
);