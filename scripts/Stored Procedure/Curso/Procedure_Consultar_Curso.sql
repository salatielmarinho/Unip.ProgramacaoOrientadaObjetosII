USE POOII;

-- Verifica se a procedure 'ConsultarCurso' existe e a exclui se existir
IF OBJECT_ID('ConsultarCurso', 'P') IS NOT NULL
    DROP PROCEDURE ConsultarCurso;
GO
-- Cria a procedure 'ConsultarCurso'
CREATE PROCEDURE ConsultarCurso        
AS
BEGIN
	SELECT * FROM Curso WITH(NOLOCK)
END;