-- Verifica se a tabela 'Aluno' existe e a exclui se existir
IF OBJECT_ID('Aluno', 'U') IS NOT NULL
    DROP TABLE Aluno;
GO

-- Cria a tabela 'Aluno'
CREATE TABLE Aluno (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Idade INT,
    Curso VARCHAR(100),
    Email VARCHAR(100) UNIQUE,
    DataDeMatricula DATE,
    Endereco VARCHAR(255),
    Telefone VARCHAR(15)
);