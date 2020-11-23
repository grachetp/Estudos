using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoWindowsFormsBiblioteca.Classes {
  public class Cliente {
    public class Unit {

      [Required(ErrorMessage = "Código do cliente é obrigatório")]
      [RegularExpression("([0-9]+)", ErrorMessage = "Código do cliente só aceita valores númericos")]
      [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do cliente deve ter 6 dígitos")]
      public string ID { get; set; }
      
      [Required(ErrorMessage = "Nome do cliente é obrigatório")]
      //[StringLength(50, MinimumLength = 3, ErrorMessage = "O mínimo de caracteres é 3")]
      [StringLength(50, ErrorMessage = "O nome do cliente deve ter no máximo 50 caracteres.")]
      public string Nome { get; set; }

      [Required(ErrorMessage = "Nome da mãe é obrigatório")]
      [StringLength(50, ErrorMessage = "O nome da mãe deve ter no máximo 50 caracteres.")]
      public string NomeMae { get; set; }

      [StringLength(50, ErrorMessage = "O nome da pai deve ter no máximo 50 caracteres.")]
      public string NomePai { get; set; }
      
      public bool NaoTemPai { get; set; }

      [Required(ErrorMessage = "CPF é obrigatório")]
      [RegularExpression("([0-9]+)", ErrorMessage = "CPF só aceita valores númericos")]
      [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos")]
      public string CPF { get; set; }

      [Required(ErrorMessage = "Gênero é obrigatório")]
      public string Genero { get; set; }

      [Required(ErrorMessage = "CPF é obrigatório")]
      [RegularExpression("([0-9]+)", ErrorMessage = "CEP só aceita valores númericos")]
      [StringLength(11, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 dígitos")]
      public string CEP { get; set; }


      [Required(ErrorMessage = "Logradouro é obrigatório")]
      [StringLength(100, ErrorMessage = "O logradouro deve ter no máximo 100 caracteres.")]
      public string Logradouro { get; set; }

      [Required(ErrorMessage = "Complemento é obrigatório")]
      [StringLength(100, ErrorMessage = "O complemento deve ter no máximo 100 caracteres.")]
      public string Complemento { get; set; }

      [Required(ErrorMessage = "Bairro é obrigatório")]
      [StringLength(50, ErrorMessage = "O bairro deve ter no máximo 50 caracteres.")]
      public string Bairro { get; set; }

      [Required(ErrorMessage = "Cidade é obrigatório")]
      [StringLength(50, ErrorMessage = "A cidade deve ter no máximo 50 caracteres.")]
      public string Cidade { get; set; }

      [Required(ErrorMessage = "Estado é obrigatório")]
      [StringLength(50, ErrorMessage = "O estado deve ter no máximo 50 caracteres.")]
      public string Estado { get; set; }

      [Required(ErrorMessage = "Número do Telefone é obrigatório")]
      [RegularExpression("([0-9]+)", ErrorMessage = "Telefone só aceita valores númericos")]
      public string Telefone { get; set; }

      public string Profissao { get; set; }

      [Required(ErrorMessage = "Renda Familiar é obrigatório")]
      [Range(0, double.MaxValue, ErrorMessage = "A renda familiar deve ser um valor positivo")]
      public double RendaFamiliar { get; set; }

      public void ValidaClasse() {
        ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
        List<ValidationResult> results = new List<ValidationResult>();
        bool isValid = Validator.TryValidateObject(this, context, results, true);

        if (isValid == false) {
          StringBuilder sbrErrors = new StringBuilder();
          foreach (var validationResult in results) {
            sbrErrors.AppendLine(validationResult.ErrorMessage);
          }
          throw new ValidationException(sbrErrors.ToString());
        }
      }

      public void ValidaComplemento() {
        if (this.NomePai == this.NomeMae) {
          throw new Exception("Nome do pai e da mãe não podem ser iguais");
        }
        if (this.NaoTemPai == false) {
          if (this.NomePai == "") {
            throw new Exception("Nome do pai não pode estar vazio. Quando a propiedade Pai Desconhecido estiver desmarcado");
          }
        }
        bool validaCpf = Cls_Uteis.Valida(this.CPF);
        if (validaCpf == false) {
          throw new Exception("CPF Ínválido");
        }
      }
    }

    public class List {
      public List<Unit> ListUnit { get; set; }
    }
  }
}
