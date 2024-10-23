USE BD_FAZENDA;

-- Verifica se a procedure 'AlterarPerfil' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarPerfil')
	BEGIN
		PRINT 'A stored procedure existe.'
	END
ELSE
	BEGIN
		-- Cria a procedure 'AlterarPerfil'
		CREATE PROCEDURE AlterarPerfil
			@NomePerfil NVARCHAR(50),
			@Id INT    
		AS
		BEGIN
			UPDATE Perfil
			SET NomePerfil = @NomePerfil
				WHERE Id = @Id
		END;