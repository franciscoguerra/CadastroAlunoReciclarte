namespace CadastroAlunoReciclarte.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public string? Logradouro { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? CEP { get; set; }
        public string? Contato { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public bool Status { get; set; }
        public IList<Aluno>? Alunos { get; set; }
    }
}
