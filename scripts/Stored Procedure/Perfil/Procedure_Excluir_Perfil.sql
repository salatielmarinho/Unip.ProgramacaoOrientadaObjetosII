USE POOII;

-- Verifica se a procedure 'ExcluirPerfil' existe e a exclui se existir
IF OBJECT_ID('ExcluirPerfil', 'P') IS NOT NULL
    DROP PROCEDURE ExcluirPerfil;
GO

-- Cria a procedure 'ExcluirPerfil'
CREATE PROCEDURE ExcluirPerfil    
    @PerfilId INT    
AS
BEGIN
	DELETE FROM Perfil
		WHERE PerfilID = @PerfilId
END;