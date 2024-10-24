USE BD_FAZENDA;

-- Verifica se a procedure 'ExcluirCliente' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirCliente')
	BEGIN
		DROP PROCEDURE ExcluirCliente;
	END
GO

-- Verifica se a procedure 'InserirCliente' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InserirCliente')
	BEGIN
		DROP PROCEDURE InserirCliente;
	END
GO

-- Verifica se a procedure 'ConsultarCliente' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarCliente')
	BEGIN
		DROP PROCEDURE ConsultarCliente;
	END
GO

-- Verifica se a procedure 'AlterarCliente' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarCliente')
	BEGIN
		DROP PROCEDURE AlterarCliente;
	END
GO	

-- Verifica se a procedure 'AlterarPerfil' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarPerfil')
	BEGIN
		DROP PROCEDURE AlterarPerfil;
	END
GO

-- Verifica se a procedure 'ConsultarPerfil' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarPerfil')
	BEGIN
		DROP PROCEDURE ConsultarPerfil;
	END
GO	

-- Verifica se a procedure 'ConsultarTodosPerfis' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarTodosPerfis')
	BEGIN
		DROP PROCEDURE ConsultarTodosPerfis;
	END
GO	

-- Verifica se a procedure 'ExcluirPerfil' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirPerfil')
	BEGIN
		DROP PROCEDURE ExcluirPerfil;
	END
GO

-- Verifica se a procedure 'InserirPerfil' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InserirPerfil')
	BEGIN
		DROP PROCEDURE InserirPerfil;
	END
GO	

-- Verifica se a procedure 'AlterarUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarUsuario')
	BEGIN
		DROP PROCEDURE AlterarUsuario;
	END
GO

-- Verifica se a procedure 'ConsultarPerfilUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarPerfilUsuario')
	BEGIN
		DROP PROCEDURE ConsultarPerfilUsuario;
	END
GO

-- Verifica se a procedure 'ConsultarUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarUsuario')
	BEGIN
		DROP PROCEDURE ConsultarUsuario;
	END
GO	

-- Verifica se a procedure 'ExcluirUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirUsuario')
	BEGIN
		DROP PROCEDURE ExcluirUsuario;
	END
GO	

-- Verifica se a procedure 'InserirUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InserirUsuario')
	BEGIN
		DROP PROCEDURE InserirUsuario;
	END
GO	

