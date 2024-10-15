USE POOII;

-- Verifica se a procedure 'InserirPerfil' existe e a exclui se existir
IF OBJECT_ID('InserirPerfil', 'P') IS NOT NULL
    DROP PROCEDURE InserirPerfil;
GO

-- Cria a procedure 'InserirPerfil'
CREATE PROCEDURE InserirPerfil
    @NomePerfil NVARCHAR(50)
AS
BEGIN
    INSERT INTO Usuario (NomePerfil)
    VALUES (@NomePerfil);
END;