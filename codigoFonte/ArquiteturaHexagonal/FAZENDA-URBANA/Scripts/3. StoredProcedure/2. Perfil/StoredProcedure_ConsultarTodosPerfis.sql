USE BD_FAZENDA;

-- Verifica se a procedure 'ConsultarTodosPerfis' existe e a exclui se existir
IF OBJECT_ID('ConsultarTodosPerfis', 'P') IS NOT NULL
    DROP PROCEDURE ConsultarTodosPerfis;
GO

-- Cria a procedure 'ConsultarTodosPerfis'
CREATE PROCEDURE ConsultarTodosPerfis    
AS
BEGIN
    SELECT Id, NomePerfil
    FROM Perfil WITH(NOLOCK)
    WHERE Ativo = 1
END;