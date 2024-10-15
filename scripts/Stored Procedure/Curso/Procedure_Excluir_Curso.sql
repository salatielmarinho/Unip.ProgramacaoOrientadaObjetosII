USE POOII;

-- Verifica se a procedure 'ExcluirCurso' existe e a exclui se existir
IF OBJECT_ID('ExcluirCurso', 'P') IS NOT NULL
    DROP PROCEDURE ExcluirCurso;
GO

-- Cria a procedure 'ExcluirCurso'
CREATE PROCEDURE ExcluirCurso    
    @CursoID INT    
AS
BEGIN
	DELETE FROM Curso
		WHERE CursoID = @CursoID
END;