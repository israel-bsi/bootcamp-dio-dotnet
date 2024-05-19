using Models;

/////Herança e Polimorfismo
var aluno = new Aluno
{
    Nome = "Israel",
    Idade = 24,
    Email = "israel@gmail.com",
    Nota = 10
};
aluno.Apresentar();

var professor = new Professor
{
    Nome = "Eduardo",
    Idade = 30,
    Salario = 1000,
};
professor.Apresentar();









////Abstração e encapsulamento
// var contaCorrente = new ContaCorrente(123, 1000);
// contaCorrente.ExibirSaldo();
// contaCorrente.Sacar(5000);
// contaCorrente.ExibirSaldo();

// var pessoa = new Pessoa
// {
//     Idade = 24,
//     Nome = "Israel Silva"
// };

// pessoa.Apresentar();