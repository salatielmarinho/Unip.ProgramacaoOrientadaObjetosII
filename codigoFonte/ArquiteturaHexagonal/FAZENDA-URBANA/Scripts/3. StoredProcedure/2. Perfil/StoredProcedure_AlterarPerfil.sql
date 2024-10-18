USE BD_FAZENDA;

-- Verifica se a procedure 'AlterarPerfil' existe e a exclui se existir
IF OBJECT_ID('AlterarPerfil', 'P') IS NOT NULL
    DROP PROCEDURE AlterarPerfil;
GO

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