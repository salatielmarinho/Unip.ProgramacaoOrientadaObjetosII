-- Cria a procedure 'AlterarUsuario'
CREATE PROCEDURE AlterarUsuario
	@Nome NVARCHAR(100),
	@Id INT    
AS
BEGIN
	UPDATE Usuario
	SET Nome = @Nome
		WHERE Id = @Id
END;