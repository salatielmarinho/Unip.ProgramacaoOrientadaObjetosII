CREATE PROCEDURE InserirAluno
    @Nome VARCHAR(100),
    @Idade INT,
    @Curso VARCHAR(100),
    @Email VARCHAR(100),
    @DataDeMatricula DATE,
    @Endereco VARCHAR(255),
    @Telefone VARCHAR(15)
AS
BEGIN
    INSERT INTO Aluno (Nome, Idade, Curso, Email, DataDeMatricula, Endereco, Telefone)
    VALUES (@Nome, @Idade, @Curso, @Email, @DataDeMatricula, @Endereco, @Telefone);
END;