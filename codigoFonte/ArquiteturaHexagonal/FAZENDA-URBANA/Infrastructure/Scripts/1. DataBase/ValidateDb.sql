IF EXISTS (SELECT * FROM sys.databases WHERE name = 'BD_FAZENDA')
BEGIN
    SELECT 1;
END
ELSE
BEGIN
    SELECT 0;
END