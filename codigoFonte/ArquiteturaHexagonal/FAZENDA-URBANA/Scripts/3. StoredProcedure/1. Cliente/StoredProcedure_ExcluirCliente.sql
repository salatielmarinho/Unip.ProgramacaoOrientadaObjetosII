USE BD_FAZENDA;

-- Verifica se a procedure 'ExcluirCliente' existe e a exclui se existir
IF OBJECT_ID('ExcluirCliente', 'P') IS NOT NULL
    DROP PROCEDURE ExcluirCliente;
GO

-- Cria a procedure 'ExcluirCliente'
CREATE PROCEDURE ExcluirCliente    
    @Id INT    
AS
BEGIN
	UPDATE Cliente
		SET Ativo = 0
		WHERE Id = @Id
END;