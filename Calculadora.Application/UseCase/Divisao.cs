using Calculadora.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Application.UseCase
{
    public class Divisao : IDivisaoUseCase
    {
        public double Handler(List<double>Lista)
        {
            var resultado = 0000000.000;

            foreach( var item in Lista) 
            {
                resultado = resultado / item;
            }

            return resultado;
        }
    }
}
