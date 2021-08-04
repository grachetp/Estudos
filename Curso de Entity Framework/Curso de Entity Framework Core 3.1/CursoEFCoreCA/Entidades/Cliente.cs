namespace CursoEFCore.Entidades
{
  //[Table("Clientes")] -> DataAnnotations -> Nome da tabela no banco de dados
  public class Cliente
  {
    //[Key] -> DataAnnotations -> Chave Primaria
    public int Id { get; set; }

    //[Required] -> DataAnnotations -> Obrigatório
    public string Nome { get; set; }

    //[Column("Phone")] -> DataAnnotations -> Nome do Atributo no BD
    public string Telefone { get; set; }
    public string CEP { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set; }
    public string Email { get; set; }
  }
}