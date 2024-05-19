namespace Models;

public class Pessoa
{
    public Pessoa() { }
    public Pessoa(string nome)
    {
        Nome = nome;
    }
    public int Idade { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public virtual void Apresentar() =>
    Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
}