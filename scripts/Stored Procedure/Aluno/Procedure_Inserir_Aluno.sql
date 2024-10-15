USE POOII;

-- Verifica se a procedure 'InserirAluno' existe e a exclui se existir
IF OBJECT_ID('InserirAluno', 'P') IS NOT NULL
    DROP PROCEDURE InserirAluno;
GO

-- Cria a procedure 'InserirAluno'
CREATE PROCEDURE InserirAluno
    @Nome VARCHAR(100),
    @DataNascimento DATE,
    @FKCurso INT    
AS
BEGIN
    INSERT INTO Aluno (Nome, DataNascimento, FKCurso)
    VALUES (@Nome, @DataNascimento, @FKCurso);
END;