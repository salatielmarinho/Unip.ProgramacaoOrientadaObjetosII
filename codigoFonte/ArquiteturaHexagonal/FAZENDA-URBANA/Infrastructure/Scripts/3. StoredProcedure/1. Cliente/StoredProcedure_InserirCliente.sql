-- Cria a procedure 'InserirCliente'
CREATE PROCEDURE InserirCliente
	@NomeCliente VARCHAR(100),    
	@Cpf VARCHAR(15),
	@Email VARCHAR(50)    
AS
BEGIN
	-- Verifica se o cliente já existe
	IF EXISTS (SELECT 1 FROM Cliente WHERE Cpf = @Cpf)
		BEGIN
			-- Se o cliente já existe, retorna uma mensagem
			PRINT 'Cliente já existe.'
		END
	ELSE
		BEGIN
			INSERT INTO Cliente (NomeCliente, CPF, Email)
			VALUES (@NomeCliente, @Cpf, @Email);
		END
END