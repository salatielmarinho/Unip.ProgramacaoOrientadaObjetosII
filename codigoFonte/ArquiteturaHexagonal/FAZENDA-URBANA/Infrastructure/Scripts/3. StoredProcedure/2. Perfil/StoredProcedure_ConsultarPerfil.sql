USE BD_FAZENDA;

-- Verifica se a procedure 'ConsultarPerfil' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarPerfil')
	BEGIN
		PRINT 'A stored procedure existe.'
	END
ELSE
	BEGIN
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