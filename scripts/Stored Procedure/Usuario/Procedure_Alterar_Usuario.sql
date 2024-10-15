USE POOII;

-- Verifica se a procedure 'AlterarUsuario' existe e a exclui se existir
IF OBJECT_ID('AlterarUsuario', 'P') IS NOT NULL
    DROP PROCEDURE AlterarUsuario;
GO

-- Cria a procedure 'AlterarUsuario'
CREATE PROCEDURE AlterarUsuario    
    @UsuarioID INT,
	@Nome NVARCHAR(100),
    @Email NVARCHAR(100),
	@Senha VARBINARY(MAX)	
AS
BEGIN
	UPDATE Usuario
		SET Nome = @Nome,
			Email = @Email,
			Senha = @Senha
		WHERE UsuarioID = @UsuarioID
END;