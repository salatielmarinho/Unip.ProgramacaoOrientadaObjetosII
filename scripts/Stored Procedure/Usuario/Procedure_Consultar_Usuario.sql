USE POOII;

-- Verifica se a procedure 'ConsultarUsuario' existe e a exclui se existir
IF OBJECT_ID('ConsultarUsuario', 'P') IS NOT NULL
    DROP PROCEDURE ConsultarUsuario;
GO
-- Cria a procedure 'ConsultarUsuario'
CREATE PROCEDURE ConsultarUsuario        
AS
BEGIN
	SELECT * FROM Usuario WITH(NOLOCK)
END;