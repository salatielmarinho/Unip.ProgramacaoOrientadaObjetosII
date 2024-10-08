USE PIM;

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