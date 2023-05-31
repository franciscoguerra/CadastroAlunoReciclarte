namespace CadastroAlunoReciclarte.Model
{
    public class Filiacao
    {
        public int id { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        //public string Outros { get; set; }
        public string cpf { get; set; }
        public string  Profissao { get; set; }
        public bool Status { get; set; }
        public IList<Aluno>? Alunos { get; set; }
    }
}
