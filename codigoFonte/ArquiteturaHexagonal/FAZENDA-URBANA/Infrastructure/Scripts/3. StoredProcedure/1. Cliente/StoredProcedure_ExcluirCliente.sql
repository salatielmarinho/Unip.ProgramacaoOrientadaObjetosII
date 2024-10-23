USE BD_FAZENDA;

-- Verifica se a procedure 'ExcluirCliente' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirCliente')
	BEGIN
		PRINT 'A stored procedure existe.'
	END
ELSE
	BEGIN
		-- Cria a procedure 'ExcluirCliente'
		CREATE PROCEDURE ExcluirCliente    
			@Id INT    
		AS
		BEGIN
			UPDATE Cliente
				SET Ativo = 0
				WHERE Id = @Id
		END;
	END;