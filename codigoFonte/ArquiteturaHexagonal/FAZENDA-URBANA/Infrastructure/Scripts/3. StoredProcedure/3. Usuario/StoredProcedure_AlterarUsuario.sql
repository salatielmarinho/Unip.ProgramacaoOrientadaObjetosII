USE BD_FAZENDA;

-- Verifica se a procedure 'AlterarUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarUsuario')
	BEGIN
		PRINT 'A stored procedure existe.'
	END
ELSE
	BEGIN
		-- Cria a procedure 'AlterarUsuario'
		CREATE PROCEDURE AlterarUsuario
			@Nome NVARCHAR(100),
			@Id INT    
		AS
		BEGIN
			UPDATE Usuario
			SET Nome = @Nome
				WHERE Id = @Id
		END;