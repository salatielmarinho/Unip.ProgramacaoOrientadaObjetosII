USE POOII;

-- Verifica se a procedure 'ConsultarPerfil' existe e a exclui se existir
IF OBJECT_ID('ConsultarPerfil', 'P') IS NOT NULL
    DROP PROCEDURE ConsultarPerfil;
GO
-- Cria a procedure 'ConsultarPerfil'
CREATE PROCEDURE ConsultarPerfil        
AS
BEGIN
	SELECT * FROM Perfil WITH(NOLOCK)
END;