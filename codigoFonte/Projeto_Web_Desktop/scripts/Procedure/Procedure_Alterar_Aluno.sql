-- Verifica se a procedure 'AlterarAluno' existe e a exclui se existir
IF OBJECT_ID('AlterarAluno', 'P') IS NOT NULL
    DROP PROCEDURE AlterarAluno;
GO

-- Cria a procedure 'AlterarAluno'
CREATE PROCEDURE AlterarAluno
    @Nome VARCHAR(100),
    @Id INT    
AS
BEGIN
	UPDATE Aluno
	SET Nome = @Nome
		WHERE ID = @Id
END;