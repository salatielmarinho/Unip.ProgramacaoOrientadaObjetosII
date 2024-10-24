USE BD_FAZENDA;

-- Verifica se a procedure 'ExcluirPerfil' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirPerfil')
	BEGIN
		PRINT 'A stored procedure existe.'
	END
ELSE
	BEGIN
		-- Cria a procedure 'ExcluirPerfil'
		CREATE PROCEDURE ExcluirPerfil    
			@Id INT    
		AS
		BEGIN
			UPDATE Perfil
				SET Ativo = 0
				WHERE Id = @Id
		END;