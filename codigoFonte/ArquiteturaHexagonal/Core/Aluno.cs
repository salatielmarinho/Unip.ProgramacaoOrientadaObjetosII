using System;
using System.Collections.Generic;

namespace Core
{
    public interface IAlunoService
    {
        bool InserirAluno(Aluno aluno);

        bool AlterarAluno(Aluno aluno);

        bool ExcluirAluno(Aluno aluno);

        List<Aluno> ConsultarAluno(int id);
    }

    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }
        public string Email { get; set; }
        public DateTime DataDeMatricula { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}