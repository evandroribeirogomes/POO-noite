using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel.models
{
    public class Gerente : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha)
        {
            if(Senha == senha){
            System.Console.WriteLine("Yes baby");
            return true;
            }
            return  false;
        }
        
    }
}