using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel.models
{
    public class Cliente : IAutenticavel
    {
        public int Senha { get; set; }
        public bool Autenticar(int senha){

            if(Senha == senha){
                System.Console.WriteLine("Esse cliente esta autenticado");
                return true;
            }
            return  false;
        }
    }


}