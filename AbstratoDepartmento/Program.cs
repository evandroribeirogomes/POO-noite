// função Main()

using AbstratoDepartmento.Models;

//Funcionario f = new Funcionario();
Assalariado a1 = new Assalariado(1, "Ana",1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);

Comissionado c1 = new Comissionado(3, "Leo", 1000, 0.20);
Comissionado c2 = new Comissionado(4, "Teo", 1000, 0.30);


Departamento d1 = new Departamento(10, "TI");
Departamento d2 = new Departamento(11, "RH");

d1.VetF = new List<Funcionario>();
d1.AdimitirFuncionario(a1);
d1.AdimitirFuncionario(c1);


d2.VetF = new List<Funcionario>();
d2.AdimitirFuncionario(a2);
d2.AdimitirFuncionario(c2);


d1.ListarFuncionario();
d2.ListarFuncionario();

Console.WriteLine("Departamento: " + d1.Descricao + "\t Total da folha de pagamento R$"
+ d1.CalcularFolhaPagamento(30));

Console.WriteLine("Departamento: " + d2.Descricao + "\t Total da folha de pagamento R$"
+ d2.CalcularFolhaPagamento(30));

d1.DemitirFunionario(1);
d1.ListarFuncionario();
