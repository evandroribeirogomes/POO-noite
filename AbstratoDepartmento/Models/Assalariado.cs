using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoDepartmento.Models
{
    public class Assalariado : Funcionario
    {
        public Assalariado(int c, string n, double s) 
                            : base(c, n, s)//referenciando a classe base
        {
        }
        public override double CalcularSalario(int diasUteis)//Reutilizando outro método aplicando o polimorfimsmo.
        {
            return Salario / 30 * diasUteis; 
        }
    }
}