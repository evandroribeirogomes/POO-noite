//funcão main

using InterfaceAutenticavel.models;

Gerente g = new Gerente();
g.Senha = 100;
System.Console.WriteLine("Autenticou?" + g.Autenticar(100));

Diretor d = new Diretor();
d.Senha = 200;
IAutenticavel id = d;
System.Console.WriteLine("Autenticou?" +  id.Autenticar(200));

Cliente c = new Cliente();
c.Senha = 300;
IAutenticavel ic = c;
System.Console.WriteLine("Autenticou?" +  id.Autenticar(300));




