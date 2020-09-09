using System;
using System.Collections.Generic;
using Calculadora.Api.Controllers.Interfaces;


namespace Calculadora.Application.UseCase
{
    public class Subtracao : ISubtracaoUseCase
    {
        public double Handler(List<double> Lista)
        {
            var resultado = 00.0;

            foreach( var item in Lista)
            {
                resultado = resultado - item;
            }
            return resultado;
        }
    }
}
