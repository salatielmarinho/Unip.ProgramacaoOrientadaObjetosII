-- Verifica se a procedure 'ExcluirCliente' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirCliente')
	BEGIN
		DROP PROCEDURE ExcluirCliente;
	END

-- Verifica se a procedure 'InserirCliente' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InserirCliente')
	BEGIN
		DROP PROCEDURE InserirCliente;
	END

-- Verifica se a procedure 'ConsultarCliente' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarCliente')
	BEGIN
		DROP PROCEDURE ConsultarCliente;
	END

-- Verifica se a procedure 'AlterarCliente' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarCliente')
	BEGIN
		DROP PROCEDURE AlterarCliente;
	END

-- Verifica se a procedure 'AlterarPerfil' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarPerfil')
	BEGIN
		DROP PROCEDURE AlterarPerfil;
	END

-- Verifica se a procedure 'ConsultarPerfil' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarPerfil')
	BEGIN
		DROP PROCEDURE ConsultarPerfil;
	END

-- Verifica se a procedure 'ConsultarTodosPerfis' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarTodosPerfis')
	BEGIN
		DROP PROCEDURE ConsultarTodosPerfis;
	END

-- Verifica se a procedure 'ExcluirPerfil' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirPerfil')
	BEGIN
		DROP PROCEDURE ExcluirPerfil;
	END

-- Verifica se a procedure 'InserirPerfil' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InserirPerfil')
	BEGIN
		DROP PROCEDURE InserirPerfil;
	END

-- Verifica se a procedure 'AlterarUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'AlterarUsuario')
	BEGIN
		DROP PROCEDURE AlterarUsuario;
	END

-- Verifica se a procedure 'ConsultarPerfilUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarPerfilUsuario')
	BEGIN
		DROP PROCEDURE ConsultarPerfilUsuario;
	END

-- Verifica se a procedure 'ConsultarUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ConsultarUsuario')
	BEGIN
		DROP PROCEDURE ConsultarUsuario;
	END

-- Verifica se a procedure 'ExcluirUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ExcluirUsuario')
	BEGIN
		DROP PROCEDURE ExcluirUsuario;
	END

-- Verifica se a procedure 'InserirUsuario' existe e a exclui se existir
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'InserirUsuario')
	BEGIN
		DROP PROCEDURE InserirUsuario;
	END