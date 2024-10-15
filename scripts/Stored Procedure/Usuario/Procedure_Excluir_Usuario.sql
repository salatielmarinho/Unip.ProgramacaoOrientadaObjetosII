USE POOII;

-- Verifica se a procedure 'ExcluirUsuario' existe e a exclui se existir
IF OBJECT_ID('ExcluirUsuario', 'P') IS NOT NULL
    DROP PROCEDURE ExcluirUsuario;
GO

-- Cria a procedure 'ExcluirUsuario'
CREATE PROCEDURE ExcluirUsuario    
    @UsuarioID INT    
AS
BEGIN
	DELETE FROM Usuario
		WHERE UsuarioID = @UsuarioID
END;