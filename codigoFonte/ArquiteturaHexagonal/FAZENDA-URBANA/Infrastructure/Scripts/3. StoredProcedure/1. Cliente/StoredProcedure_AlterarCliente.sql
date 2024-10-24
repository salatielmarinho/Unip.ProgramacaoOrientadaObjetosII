USE BD_FAZENDA;



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