using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMvc.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key] //Chave Primária
        public int Id { get; set; }

        [Required] //Obrigatório
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Endereço")] //Apelido que aparece na view
        public string Endereco { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] //Formatação para padrão brasileiro de tempo
        public DateTime Nascimento { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}