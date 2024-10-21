USE BD_FAZENDA;

-- Verifica se a procedure 'InserirUsuario' existe e a exclui se existir
IF OBJECT_ID('InserirUsuario', 'P') IS NOT NULL
    DROP PROCEDURE InserirUsuario;
GO

-- Cria a procedure 'InserirUsuario'
CREATE PROCEDURE InserirUsuario
    @Fk_Perfil INT,
	@Nome NVARCHAR(100),
	@Cep NVARCHAR(15),
	@Endereco NVARCHAR(100),
	@Complemento NVARCHAR(50),
	@Numero NVARCHAR(10),
	@Bairro NVARCHAR(100),
	@Uf NVARCHAR(2),
	@Email NVARCHAR(100),
	@Senha NVARCHAR(20)
AS
BEGIN
    -- Verifica se pessoa já existe
    IF EXISTS (SELECT 1 FROM Usuario WHERE Nome = @Nome)
    BEGIN
        -- Se pessoa já existe, retorna uma mensagem
        PRINT 'Usuário(a) já existe.'
    END
    ELSE
		BEGIN
			INSERT INTO Usuario (Fk_Perfil, Nome, Cep, Endereco, Complemento, Numero, Bairro,
			UF, Email, Senha)
			VALUES (@Fk_Perfil, @Nome, @Cep, @Endereco, @Complemento, @Numero, @Bairro,
			@Uf, @Email, @Senha);
		END;
END;