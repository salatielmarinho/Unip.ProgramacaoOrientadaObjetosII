USE BD_FAZENDA;

-- Verifica se a procedure 'ConsultarPerfil' existe e a exclui se existir
IF OBJECT_ID('ConsultarPerfil', 'P') IS NOT NULL
    DROP PROCEDURE ConsultarPerfil;
GO

-- Cria a procedure 'ConsultarPerfil'
CREATE PROCEDURE ConsultarPerfil
    @NomePerfil NVARCHAR(50)
AS
BEGIN
    SELECT Id, NomePerfil, DataCriacao
    FROM Perfil WITH(NOLOCK)
    WHERE NomePerfil LIKE '%' + @NomePerfil + '%'
	AND Ativo = 1
END;