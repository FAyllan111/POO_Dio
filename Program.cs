using POO_Dio.Models;

Pessoa p1 = new Pessoa(); // cria o objeto da classe e classe é o molde

p1.Nome = "Fsksk";
p1.Idade = 134;

//p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123,5000);

c1.ExibirSaldo();
c1.RealizarSaque(3000);
c1.ExibirSaldo();
c1.RealizarSaque(3000);
c1.ExibirSaldo();
