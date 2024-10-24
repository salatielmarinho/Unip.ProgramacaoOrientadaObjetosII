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