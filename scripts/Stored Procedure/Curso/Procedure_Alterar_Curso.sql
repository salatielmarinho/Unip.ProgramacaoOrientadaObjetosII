USE POOII;

-- Verifica se a procedure 'AlterarCurso' existe e a exclui se existir
IF OBJECT_ID('AlterarCurso', 'P') IS NOT NULL
    DROP PROCEDURE AlterarCurso;
GO

-- Cria a procedure 'AlterarCurso'
CREATE PROCEDURE AlterarCurso    
    @CursoID INT,
	@NomeCurso NVARCHAR(100),
    @Descricao NVARCHAR(255)	
AS
BEGIN
	UPDATE Curso
		SET NomeCurso = @NomeCurso,
			Descricao = @Descricao
		WHERE CursoID = @CursoID
END;