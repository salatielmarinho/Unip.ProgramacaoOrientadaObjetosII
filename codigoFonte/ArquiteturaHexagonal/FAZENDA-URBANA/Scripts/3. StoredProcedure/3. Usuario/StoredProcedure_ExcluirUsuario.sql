USE BD_FAZENDA;

-- Verifica se a procedure 'ExcluirUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirUsuario')
	BEGIN
		PRINT 'A stored procedure existe.'
	END
ELSE
	BEGIN
		-- Cria a procedure 'ExcluirUsuario'
		CREATE PROCEDURE ExcluirUsuario    
			@Id INT    
		AS
		BEGIN
			UPDATE Usuario
				SET Ativo = 0
				WHERE Id = @Id
		END;
	END;