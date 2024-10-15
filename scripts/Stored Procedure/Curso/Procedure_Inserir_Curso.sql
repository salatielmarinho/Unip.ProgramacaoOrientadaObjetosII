USE POOII;

-- Verifica se a procedure 'InserirCurso' existe e a exclui se existir
IF OBJECT_ID('InserirCurso', 'P') IS NOT NULL
    DROP PROCEDURE InserirCurso;
GO

-- Cria a procedure 'InserirCurso'
CREATE PROCEDURE InserirCurso
    @NomeCurso VARCHAR(100),
    @Descricao VARCHAR(255)  
AS
BEGIN
    INSERT INTO Curso (NomeCurso, Descricao)
    VALUES (@NomeCurso, @Descricao);
END;