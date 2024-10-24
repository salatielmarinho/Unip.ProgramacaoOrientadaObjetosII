-- Cria a procedure 'ExcluirPerfil'
CREATE PROCEDURE ExcluirPerfil    
	@Id INT    
AS
BEGIN
	UPDATE Perfil
		SET Ativo = 0
		WHERE Id = @Id
END;