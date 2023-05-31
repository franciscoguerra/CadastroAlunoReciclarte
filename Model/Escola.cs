namespace CadastroAlunoReciclarte.Model
{
    public class Escola
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataMatricula { get; set; }
        public bool Transporte { get; set; }
        public bool AtvPropostaPelaEscola { get; set; }
        //public bool OpEnsinoReligioso { get; set; }
        public bool Beneficios { get; set; }
        public bool Regresso { get; set; }
        public string AlertaEmergencia { get; set; }
        public bool PortadorNescessidades { get; set; }
        //public int IdAluno { get; set; }
        public ICollection<Aluno>? Alunos { get; set; }
        public bool Status { get; set; }
    }
}
