USE PIM;

-- Criação da tabela Aluno
CREATE TABLE Aluno (
    AlunoID INT IDENTITY(1,1) PRIMARY KEY,
    NomeAluno NVARCHAR(100) NOT NULL,
    DataNascimento DATE,
    CursoID INT,
    FOREIGN KEY (CursoID) REFERENCES Curso(CursoID)
);