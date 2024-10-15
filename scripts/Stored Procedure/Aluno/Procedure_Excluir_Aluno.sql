USE POOII;

-- Verifica se a procedure 'ExcluirAluno' existe e a exclui se existir
IF OBJECT_ID('ExcluirAluno', 'P') IS NOT NULL
    DROP PROCEDURE ExcluirAluno;
GO

-- Cria a procedure 'ExcluirAluno'
CREATE PROCEDURE ExcluirAluno    
    @Id INT    
AS
BEGIN
	DELETE FROM Aluno
		WHERE Id = @Id
END;