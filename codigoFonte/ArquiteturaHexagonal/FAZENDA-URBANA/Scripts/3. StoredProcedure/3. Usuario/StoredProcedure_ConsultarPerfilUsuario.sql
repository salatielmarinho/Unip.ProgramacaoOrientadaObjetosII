USE BD_FAZENDA;

-- Verifica se a procedure 'ConsultarPerfilUsuario' existe e a exclui se existir
IF OBJECT_ID('ConsultarPerfilUsuario', 'P') IS NOT NULL
    DROP PROCEDURE ConsultarPerfilUsuario;
GO

-- Cria a procedure 'ConsultarPerfilUsuario'
CREATE PROCEDURE ConsultarPerfilUsuario
    @NomeUsuario NVARCHAR(50),
	@Senha NVARCHAR(20)
AS
BEGIN
    SELECT usr.FK_Perfil
    FROM Usuario AS usr
	INNER JOIN Perfil AS per
	ON usr.Fk_Perfil = per.Id
    WHERE usr.Nome LIKE '%' + @NomeUsuario + '%'
		  AND usr.Senha = @Senha
		  AND per.Ativo = 1
		  AND usr.Ativo = 1
END;