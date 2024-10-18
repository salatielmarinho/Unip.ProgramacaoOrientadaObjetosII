IF EXISTS (SELECT * FROM sys.databases WHERE name = 'BD_FAZENDA')
BEGIN
    PRINT 'O banco de dados já existe.'
END
ELSE
BEGIN
    CREATE DATABASE BD_FAZENDA;
    PRINT 'Banco de dados criado com sucesso.'
END