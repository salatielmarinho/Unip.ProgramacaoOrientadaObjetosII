-- Cria a procedure 'ConsultarTodosPerfis'
CREATE PROCEDURE ConsultarTodosPerfis    
AS
BEGIN
	SELECT Id, NomePerfil
	FROM Perfil WITH(NOLOCK)
	WHERE Ativo = 1
END;