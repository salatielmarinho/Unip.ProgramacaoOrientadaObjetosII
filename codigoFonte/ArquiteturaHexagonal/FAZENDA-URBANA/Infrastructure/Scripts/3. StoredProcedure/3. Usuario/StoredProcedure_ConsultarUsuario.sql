-- Cria a procedure 'ConsultarUsuario'
CREATE PROCEDURE ConsultarUsuario
	@NomeUsuario NVARCHAR(50)
AS
BEGIN
	SELECT usr.Id, per.NomePerfil, usr.Nome, usr.Cep, usr.Endereco, usr.Complemento,
	usr.Numero, usr.Bairro, usr.UF, usr.Email, usr.DataCriacao
	FROM Usuario AS usr
	INNER JOIN Perfil AS per
	ON usr.Fk_Perfil = per.Id
	WHERE usr.Nome LIKE '%' + @NomeUsuario + '%'
	AND usr.Ativo = 1
END;	