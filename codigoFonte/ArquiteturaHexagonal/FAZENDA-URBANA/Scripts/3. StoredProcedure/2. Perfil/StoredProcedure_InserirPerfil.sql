USE BD_FAZENDA;

-- Verifica se a procedure 'InserirPerfil' existe e a exclui se existir
IF OBJECT_ID('InserirPerfil', 'P') IS NOT NULL
    DROP PROCEDURE InserirPerfil;
GO

-- Cria a procedure 'InserirPerfil'
CREATE PROCEDURE InserirPerfil
    @NomePerfil NVARCHAR(50)      
AS
BEGIN
    -- Verifica se o perfil já existe
    IF EXISTS (SELECT 1 FROM Perfil WHERE NomePerfil = @NomePerfil)
    BEGIN
        -- Se o perfil já existe, retorna uma mensagem
        PRINT 'Perfil já existe.'
    END
    ELSE
		BEGIN
			INSERT INTO Perfil (NomePerfil)
			VALUES (@NomePerfil);
		END;
END;