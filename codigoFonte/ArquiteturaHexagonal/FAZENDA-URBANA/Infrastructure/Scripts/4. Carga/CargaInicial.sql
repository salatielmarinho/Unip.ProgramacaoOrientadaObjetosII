IF NOT EXISTS (SELECT 1 FROM [dbo].[Perfil] WHERE [NomePerfil] = 'Admin')
BEGIN
    INSERT INTO [dbo].[Perfil]
           ([NomePerfil]
           ,[Ativo]
           ,[DataCriacao])
     VALUES
           ('Admin'
           ,1
           ,GETDATE())
    PRINT 'Perfil inserida com sucesso.';
END
ELSE
BEGIN
    PRINT 'Perfil já existe no banco de dados.';
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Perfil] WHERE [NomePerfil] = 'Usuario')
BEGIN
    INSERT INTO [dbo].[Perfil]
           ([NomePerfil]
           ,[Ativo]
           ,[DataCriacao])
     VALUES
           ('Usuario'
           ,1
           ,GETDATE())
    PRINT 'Perfil inserida com sucesso.';
END
ELSE
BEGIN
    PRINT 'Perfil já existe no banco de dados.';
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Usuario] WHERE [Email] = 'admin@unip.br')
BEGIN
    INSERT INTO [dbo].[Usuario]
               ([Fk_Perfil]
               ,[Nome]
               ,[Cep]
               ,[Endereco]
               ,[Complemento]
               ,[Numero]
               ,[Bairro]
               ,[UF]
               ,[Email]
               ,[Senha]
               ,[Ativo]
               ,[DataCriacao])
         VALUES
               (1
               ,'admin'
               ,'08240-270'
               ,'Rua Unip'
               ,'Unip'
               ,'1'
               ,'São Paulo'
               ,'SP'
               ,'admin@unip.br'
               ,'ef797c8118f02dfb6496'
               ,1
               ,GETDATE())
        PRINT 'Pessoa inserida com sucesso.';
END
ELSE
BEGIN
    PRINT 'A pessoa já existe no banco de dados.';
END