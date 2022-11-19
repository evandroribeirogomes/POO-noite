using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel.models
{
    public class Diretor : Funcionario, IAutenticavel
    {
     public bool Autenticar(int senha)
     {
        if (Senha == senha)
        {
            System.Console.WriteLine("Let's Go ");
            return true;
        }
            return  false;
    }
        
    }
}