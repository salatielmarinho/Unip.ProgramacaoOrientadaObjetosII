-------------------------------------------------------------------------
--					CRIAR TABELAS                                     ---
-------------------------------------------------------------------------
--Setar base de Dados MVP
USE MVP;

-- Verificar se a tabela existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'Usuarios' AND 
schema_id = SCHEMA_ID(N'dbo'))

BEGIN
	-- Criação da tabela Usuarios
	CREATE TABLE Usuarios (
		UsuarioID INT PRIMARY KEY IDENTITY(1,1),
		Nome NVARCHAR(100) NOT NULL,
		Email NVARCHAR(100) NOT NULL UNIQUE,
		Senha NVARCHAR(100) NOT NULL,
		DataCriacao DATETIME DEFAULT GETDATE()
	);
	PRINT 'Tabela criada com sucesso.';
END
ELSE
BEGIN
    PRINT 'A tabela já existe.';
END

-- Verificar se a tabela existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'Perfis' AND 
schema_id = SCHEMA_ID(N'dbo'))

BEGIN
	--Criação da tabela Perfis
	CREATE TABLE Perfis (
		PerfilID INT PRIMARY KEY IDENTITY(1,1),
		NomePerfil NVARCHAR(50) NOT NULL
	);
	PRINT 'Tabela criada com sucesso.';
END
ELSE
BEGIN
    PRINT 'A tabela já existe.';
END

-- Verificar se a tabela existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'UsuarioPerfis' AND 
schema_id = SCHEMA_ID(N'dbo'))
BEGIN
	--Criação da tabela UsuáriosPerfis
	CREATE TABLE UsuarioPerfis (
		UsuarioID INT NOT NULL,
		PerfilID INT NOT NULL,
		PRIMARY KEY (UsuarioID, PerfilID),
		FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID),
		FOREIGN KEY (PerfilID) REFERENCES Perfis(PerfilID)
	);
	PRINT 'Tabela criada com sucesso.';
END
ELSE
BEGIN
    PRINT 'A tabela já existe.';
END

-- Verificar se a tabela existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'Curso' AND 
schema_id = SCHEMA_ID(N'dbo'))
BEGIN
	-- Criação da tabela Curso
	CREATE TABLE Curso (
		CursoID INT IDENTITY(1,1) PRIMARY KEY,
		NomeCurso NVARCHAR(100) NOT NULL,
		Descricao NVARCHAR(255)
	);
	PRINT 'Tabela criada com sucesso.';
END
ELSE
BEGIN
    PRINT 'A tabela já existe.';
END

-- Verificar se a tabela existe
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'Aluno' AND 
schema_id = SCHEMA_ID(N'dbo'))
BEGIN
	-- Criação da tabela Aluno
	CREATE TABLE Aluno (
		AlunoID INT IDENTITY(1,1) PRIMARY KEY,
		NomeAluno NVARCHAR(100) NOT NULL,
		DataNascimento DATE,
		CursoID INT,
		FOREIGN KEY (CursoID) REFERENCES Curso(CursoID)
	);
	PRINT 'Tabela criada com sucesso.';
END
ELSE
BEGIN
    PRINT 'A tabela já existe.';
END

-------------------------------------------------------------------------
--					PROCESSO DE CARGA                                 ---
-------------------------------------------------------------------------

-- Inserção de dados na tabela Curso
INSERT INTO Curso (NomeCurso, Descricao)
VALUES ('Análise e Desenvolvimento de Sistemas', 'O curso superior de Tecnologia em Análise e Desenvolvimento de Sistemas da UNIP tem o objetivo de capacitar o aluno a projetar, documentar, especificar, implementar, testar, implantar e manter sistemas computacionais de informação.'),
       ('Redes', 'O curso superior de Tecnologia em Redes de Computadores tem como objetivo formar profissionais atualizados com as tecnologias de redes existentes no mercado e capazes de desenvolver e implantar projetos, configurar e gerenciar ambientes de redes.'),
	   ('Gestão da Tecnologia da Informação', 'O curso Superior de Tecnologia em Gestão da Tecnologia da Informação tem como objetivo capacitar o aluno a definir o Sistema de Informação a ser utilizado na Gestão dos Negócios de uma empresa, seja ela da área do comércio, indústria ou de serviços.');

-- Inserção de dados na tabela Aluno
INSERT INTO Aluno (NomeAluno, DataNascimento, CursoID)
VALUES ('João Silva', '2000-01-15', 1),
       ('Maria Oliveira', '1999-05-23', 2),
	   ('Salatiel Marinho', '1989-05-23', 3);

-- Inserção de dados na tabela Usuários
INSERT INTO Usuarios (Nome, Email, Senha) VALUES ('João Silva', 'joao.silva@example.com', 'senha123');
INSERT INTO Usuarios (Nome, Email, Senha) VALUES ('Maria Oliveira', 'maria.oliveira@example.com', 'senha456');

-- Inserção de dados na tabela Perfis
INSERT INTO Perfis (NomePerfil) VALUES ('Administrador');
INSERT INTO Perfis (NomePerfil) VALUES ('Gerente');

-- Inserção de dados na tabela UsuarioPerfis
INSERT INTO UsuarioPerfis (UsuarioID, PerfilID) VALUES (1, 1); -- João Silva como Administrador
INSERT INTO UsuarioPerfis (UsuarioID, PerfilID) VALUES (2, 2); -- Maria Oliveira como Gerente
