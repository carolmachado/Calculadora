using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Application.UseCase
{
   public class Multiplicacao : IMultiplicacaoUseCase
   {
        public double Handler (List<double> Lista) 
        {
            var resultado = 00000000.0;

            foreach (var item in Lista)
            {
                resultado = resultado * item;
            }
            return resultado;
        }
   }
}
