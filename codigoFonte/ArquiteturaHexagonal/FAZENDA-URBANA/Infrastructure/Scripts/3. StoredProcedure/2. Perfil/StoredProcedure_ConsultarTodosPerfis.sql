USE BD_FAZENDA;

-- Verifica se a procedure 'ConsultarTodosPerfis' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarTodosPerfis')
	BEGIN
		DROP PROCEDURE ConsultarTodosPerfis;
	END
GO	

-- Cria a procedure 'ConsultarTodosPerfis'
CREATE PROCEDURE ConsultarTodosPerfis    
AS
BEGIN
	SELECT Id, NomePerfil
	FROM Perfil WITH(NOLOCK)
	WHERE Ativo = 1
END;