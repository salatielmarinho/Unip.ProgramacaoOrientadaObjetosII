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