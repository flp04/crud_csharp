namespace ModuloAPI.Entities
{
  public class Contato
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public bool Ativo { get; set; }

    public Contato() {}
    public Contato(string nome, string telefone, bool ativo)
    {
      Nome = nome;
      Telefone = telefone;
      Ativo = ativo;
    }
  }
}