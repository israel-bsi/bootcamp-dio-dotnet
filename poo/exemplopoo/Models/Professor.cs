namespace Models;

public class Professor : Pessoa
{
    public Professor() { }
    public Professor(string nome) : base(nome) { }
    public decimal Salario { get; set; }
    public override void Apresentar() =>
    Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um professor e ganho {Salario}");
}