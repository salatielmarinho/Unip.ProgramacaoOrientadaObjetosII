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