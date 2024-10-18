USE BD_FAZENDA;

-- Verifica se a procedure 'AlterarUsuario' existe e a exclui se existir
IF OBJECT_ID('AlterarUsuario', 'P') IS NOT NULL
    DROP PROCEDURE AlterarUsuario;
GO

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