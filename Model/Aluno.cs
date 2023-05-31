namespace CadastroAlunoReciclarte.Model
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Rg { get; set; }
        public string EmissorRg { get; set; }
        public string cpf { get; }
        public string Nacionalidade { get; set; }
        public string CorRaca { get; set; }
        public int CodigoINEP { get; set; }
        public int CartaoSUS { get; set; }
        public string Situacao { get; set; }
        public string Etapa { get; set; }
        public bool Status { get; set; }

        public IList<Curso>? Cursos { get; set; }
        public int CursoId { get; set; }

        public IList<Turma>? Turmas { get; set; }
        public int TurmaId { get; set; }

        public int EscolaId { get; set; }
        public Escola? Escola { get; set; }

        public int EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }

        public int FiliacaoId { get; set; }
        public Filiacao? Filiacao { get; set; }

        //public Curso? Curso { get; set; }
        //public Turma? Turma { get; set; }

    }
}
