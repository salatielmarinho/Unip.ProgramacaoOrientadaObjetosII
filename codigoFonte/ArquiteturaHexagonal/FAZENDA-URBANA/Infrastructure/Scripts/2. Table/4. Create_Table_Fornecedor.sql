USE BD_FAZENDA;

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Fornecedor')
BEGIN
    PRINT 'A tabela já existe.'
END
ELSE
BEGIN
	CREATE TABLE Fornecedor 
	(
		  Id INT NOT NULL PRIMARY KEY IDENTITY,
		  NomeEmpresa VARCHAR(50) NOT NULL,
		  CNPJ VARCHAR(20) NOT NULL,
		  Adubo VARCHAR(30) NOT NULL,
		  QuantidadeAdubo INT NOT NULL,
		  Agrotoxico VARCHAR(30) NOT NULL,
		  QuantidadeAgrotoxico INT NOT NULL,
		  Muda VARCHAR(30) NOT NULL,
		  QuantidadeMuda INT NOT NULL,
		  Status BIT DEFAULT 1,
		  DataCriacao DATETIME DEFAULT GETDATE()
	);
	PRINT 'Tabela criada com sucesso.'
END
