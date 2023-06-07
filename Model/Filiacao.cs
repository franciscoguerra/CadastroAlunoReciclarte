namespace CadastroAlunoReciclarte.Model
{
    public class Filiacao
    {
        public int Id { get; set; }
        public string? NomePai { get; set; }
        public string? NomeMae { get; set; }
        //public string Outros { get; set; }
        public string? Cpf { get; set; }
        public string?  Profissao { get; set; }
        public bool Status { get; set; }
        public IList<Aluno>? Alunos { get; set; }

        public void CpfDuplicidade()
        {
            var cpfDup = Cpf.Distinct();
            foreach (var item in cpfDup)
            {
                if (item == item)
                {
                    throw new Exception("CPF duplicado!");
                }
            }
        }
    }
}
