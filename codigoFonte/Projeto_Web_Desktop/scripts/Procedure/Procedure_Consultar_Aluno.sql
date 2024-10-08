-- Verifica se a procedure 'ConsultarAluno' existe e a exclui se existir
IF OBJECT_ID('ConsultarAluno', 'P') IS NOT NULL
    DROP PROCEDURE ConsultarAluno;
GO
-- Cria a procedure 'ConsultarAluno'
CREATE PROCEDURE ConsultarAluno        
AS
BEGIN
	SELECT * FROM Aluno WITH(NOLOCK)
END;