USE [BD_FAZENDA]
GO

INSERT INTO [dbo].[Perfil]
           ([NomePerfil]
           ,[Ativo]
           ,[DataCriacao])
     VALUES
           ('Admin'
           ,1
           ,GETDATE())
GO

INSERT INTO [dbo].[Perfil]
           ([NomePerfil]
           ,[Ativo]
           ,[DataCriacao])
     VALUES
           ('Usuario'
           ,2
           ,GETDATE())
GO

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
GO