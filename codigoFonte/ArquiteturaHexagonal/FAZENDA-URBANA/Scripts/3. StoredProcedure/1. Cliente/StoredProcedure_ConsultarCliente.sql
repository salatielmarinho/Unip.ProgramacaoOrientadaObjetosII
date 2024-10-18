USE BD_FAZENDA;

-- Verifica se a procedure 'ConsultarCliente' existe e a exclui se existir
IF OBJECT_ID('ConsultarCliente', 'P') IS NOT NULL
    DROP PROCEDURE ConsultarCliente;
GO

-- Cria a procedure 'ConsultarCliente'
CREATE PROCEDURE ConsultarCliente
    @NomeCliente VARCHAR(15)
AS
BEGIN
    SELECT Id, NomeCliente, CPF, Email, DataCriacao
    FROM Cliente WITH(NOLOCK)
    WHERE NomeCliente LIKE '%' + @NomeCliente + '%'
	AND Ativo = 1
END;