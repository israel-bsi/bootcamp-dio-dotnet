using Models;

var contaCorrente = new ContaCorrente(123, 1000);
contaCorrente.ExibirSaldo();
contaCorrente.Sacar(5000);
contaCorrente.ExibirSaldo();

// var pessoa = new Pessoa
// {
//     Idade = 24,
//     Nome = "Israel Silva"
// };

// pessoa.Apresentar();