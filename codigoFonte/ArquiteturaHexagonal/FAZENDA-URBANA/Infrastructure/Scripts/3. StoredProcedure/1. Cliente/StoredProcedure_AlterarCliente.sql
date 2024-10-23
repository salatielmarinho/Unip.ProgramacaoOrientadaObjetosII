USE BD_FAZENDA;

-- Verifica se a procedure 'AlterarCliente' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarCliente')
	BEGIN
		PRINT 'A stored procedure existe.'
	END
ELSE
	BEGIN
		-- Cria a procedure 'AlterarCliente'
		CREATE PROCEDURE AlterarCliente
			@NomeCliente VARCHAR(100),
			@Id INT    
		AS
		BEGIN
			UPDATE Cliente
			SET NomeCliente = @NomeCliente
				WHERE Id = @Id
		END;
	END;