namespace Models;

public class Pessoa
{
    public int Idade { get; set; }
    public string Nome { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
    }
}