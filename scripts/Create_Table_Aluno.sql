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