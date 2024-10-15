USE POOII;

-- Verifica se a procedure 'AlterarPerfil' existe e a exclui se existir
IF OBJECT_ID('AlterarPerfil', 'P') IS NOT NULL
    DROP PROCEDURE AlterarPerfil;
GO

-- Cria a procedure 'AlterarPerfil'
CREATE PROCEDURE AlterarPerfil    
    @PerfilID INT,
	@NomePerfil NVARCHAR(50)    	
AS
BEGIN
	UPDATE Perfil
		SET NomePerfil = @NomePerfil
		WHERE PerfilID = @PerfilID
END;