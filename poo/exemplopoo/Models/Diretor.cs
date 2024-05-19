namespace Models;

public class Diretor : Professor
{
    public override void Apresentar()
    {
        //Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um diretor e ganho {Salario}");
        Console.WriteLine("Diretor");
    }
}