using System;

class Program
{
    static int CalcularDano(int ataque, int defesa)
    {
        var dano = ataque - defesa;
        if (dano < 0)
        {
            return 0;
        }
        return dano;
    }
    static void Main(string[] args)
    {
        int ataque = int.Parse(Console.ReadLine());

        int defesa = int.Parse(Console.ReadLine());

        int danoCausado = CalcularDano(ataque, defesa);
        Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);
    }
}