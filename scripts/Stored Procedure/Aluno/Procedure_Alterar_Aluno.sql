USE POOII;

-- Verifica se a procedure 'AlterarAluno' existe e a exclui se existir
IF OBJECT_ID('AlterarAluno', 'P') IS NOT NULL
    DROP PROCEDURE AlterarAluno;
GO

-- Cria a procedure 'AlterarAluno'
CREATE PROCEDURE AlterarAluno    
    @Id INT,
	@Nome VARCHAR(100),
    @DataNascimento DATE,
	@Status BIT
AS
BEGIN
	UPDATE Aluno
		SET Nome = @Nome,
			DataNascimento = @DataNascimento,
			Status = @Status
		WHERE Id = @Id
END;