USE BD_FAZENDA;

-- Verifica se a procedure 'ExcluirUsuario' existe e a exclui se existir
IF OBJECT_ID('ExcluirUsuario', 'P') IS NOT NULL
    DROP PROCEDURE ExcluirUsuario;
GO

-- Cria a procedure 'ExcluirUsuario'
CREATE PROCEDURE ExcluirUsuario    
    @Id INT    
AS
BEGIN
	UPDATE Usuario
		SET Ativo = 0
		WHERE Id = @Id
END;