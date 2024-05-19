namespace Models;

public class ContaCorrente
{
    public ContaCorrente(int numeroConta, decimal SaldoInicial)
    {
        NumeroConta = numeroConta;
        Saldo = SaldoInicial;
    }
    public int NumeroConta { get; set; }
    private decimal Saldo;
    public void Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso");
            return;
        }
        Console.WriteLine("Valor desejado é maior que o saldo disponível");
    }
    public void ExibirSaldo() => Console.WriteLine($"Seu saldo disponível é: {Saldo}");
}