USE BD_FAZENDA;

-- Verifica se a procedure 'AlterarCliente' existe e a exclui se existir
IF OBJECT_ID('AlterarCliente', 'P') IS NOT NULL
    DROP PROCEDURE AlterarCliente;
GO

-- Cria a procedure 'AlterarCliente'
CREATE PROCEDURE AlterarCliente
    @NomeCliente VARCHAR(100),
    @Id INT    
AS
BEGIN
	UPDATE Cliente
	SET NomeCliente = @NomeCliente
		WHERE Id = @Id
END;