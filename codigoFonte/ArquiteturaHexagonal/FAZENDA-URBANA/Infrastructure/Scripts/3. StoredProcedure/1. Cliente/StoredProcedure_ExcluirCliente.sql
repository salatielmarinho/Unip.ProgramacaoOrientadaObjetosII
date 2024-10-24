-- Cria a procedure 'ExcluirCliente'
CREATE PROCEDURE ExcluirCliente    
	@Id INT    
AS
BEGIN
	UPDATE Cliente
		SET Ativo = 0
		WHERE Id = @Id
END;