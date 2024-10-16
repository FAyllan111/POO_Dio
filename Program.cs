using POO_Dio.Models;

Pessoa p1 = new Pessoa(); // cria o objeto da classe e classe é o molde

p1.Nome = "Frisk";
p1.Idade = 134;

//p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123,5000);

//c1.ExibirSaldo();
//c1.RealizarSaque(3000);
//c1.ExibirSaldo();
//c1.RealizarSaque(3000);
//c1.ExibirSaldo();

Aluno a1 = new Aluno();

a1.Nome = "Aluno";
a1.Idade = 123;
a1.Nota = 258;

a1.Apresentar();

Professor pr1 = new Professor();

pr1.Nome = "Professor";
pr1.Idade = 99;
pr1.Salario = 34324;
pr1.Apresentar();