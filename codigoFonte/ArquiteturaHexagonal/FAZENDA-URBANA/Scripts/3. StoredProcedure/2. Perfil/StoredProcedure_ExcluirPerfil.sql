USE BD_FAZENDA;

-- Verifica se a procedure 'ExcluirPerfil' existe e a exclui se existir
IF OBJECT_ID('ExcluirPerfil', 'P') IS NOT NULL
    DROP PROCEDURE ExcluirPerfil;
GO

-- Cria a procedure 'ExcluirPerfil'
CREATE PROCEDURE ExcluirPerfil    
    @Id INT    
AS
BEGIN
	UPDATE Perfil
		SET Ativo = 0
		WHERE Id = @Id
END;