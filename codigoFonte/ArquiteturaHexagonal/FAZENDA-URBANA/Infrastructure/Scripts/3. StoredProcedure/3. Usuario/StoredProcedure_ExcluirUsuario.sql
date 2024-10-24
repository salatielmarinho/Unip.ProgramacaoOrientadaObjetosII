-- Cria a procedure 'ExcluirUsuario'
CREATE PROCEDURE ExcluirUsuario    
	@Id INT    
AS
BEGIN
	UPDATE Usuario
		SET Ativo = 0
		WHERE Id = @Id
END;	