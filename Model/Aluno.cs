using System.ComponentModel.DataAnnotations;
namespace CadastroAlunoReciclarte.Model
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Obrigatorio!")]
        [StringLength(120, MinimumLength =15, ErrorMessage ="Minimo de 15 caracteree.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatorio!")]
        public DateTime DataNascimento { get; set; }
        public string? Sexo { get; set; }
        public string? Rg { get; set; }
        public string? EmissorRg { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório")]
        [RegularExpression(@"^[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}$", ErrorMessage = "CPF inválido")]
        public string? Cpf { get; }

        public string? Nacionalidade { get; set; }
        public string? CorRaca { get; set; }
        public int CodigoINEP { get; set; }
        public int CartaoSUS { get; set; }
        public string? Situacao { get; set; }
        public string? Etapa { get; set; }
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

        public void DataNasc()
        {
            if(DataNascimento > DateTime.Today || DataNascimento < DateTime.MinValue.AddYears(100))
            {

                throw new Exception(" Data de Nascimento invalida!");
            }
        }

        public void CpfDuplicidade()
        {
            var cpfDup = Cpf.Distinct();

            foreach(var item in cpfDup)
            {
                if(item == item)
                {
                    throw new Exception("CPF duplicado!");
                }
            }
        }


    }

}
