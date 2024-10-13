USE BD_FAZENDA;

-- Verifica se a procedure 'InserirUsuario' existe e a exclui se existir
IF OBJECT_ID('InserirUsuario', 'P') IS NOT NULL
    DROP PROCEDURE InserirUsuario;
GO

-- Cria a procedure 'InserirUsuario'
CREATE PROCEDURE InserirUsuario
    @Nome NVARCHAR(100),
    @Cep NVARCHAR(15),
    @Endereco NVARCHAR(100),
    @Complemento NVARCHAR(50),
    @Numero NVARCHAR(10),
    @Bairro NVARCHAR(100),
    @UF NVARCHAR(2),
    @Email NVARCHAR(100),
    @Senha VARBINARY(MAX)
AS
BEGIN
    -- Verifica se o usuário já existe
    IF EXISTS (SELECT 1 FROM Usuarios WHERE Email = @Email)
    BEGIN
        -- Se o usuário já existe, retorna uma mensagem
        PRINT 'Usuário já existe.'
    END
    ELSE
		BEGIN
			INSERT INTO Usuarios (Nome, Cep, Endereco, Complemento, Numero, Bairro, UF, Email, Senha, DataCriacao)
			VALUES (@Nome, @Cep, @Endereco, @Complemento, @Numero, @Bairro, @UF, @Email, @Senha, GETDATE());
		END;
END;
