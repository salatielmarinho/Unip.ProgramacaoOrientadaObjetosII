USE POOII;

-- Verifica se a procedure 'InserirCurso' existe e a exclui se existir
IF OBJECT_ID('InserirCurso', 'P') IS NOT NULL
    DROP PROCEDURE InserirCurso;
GO

-- Cria a procedure 'InserirCurso'
CREATE PROCEDURE InserirCurso
    @Nome VARCHAR(100),
    @Email VARCHAR(100),
	@Senha VARBINARY(MAX)
AS
BEGIN
    INSERT INTO Usuario (Nome, Email, Senha)
    VALUES (@Nome, @Email, @Senha);
END;