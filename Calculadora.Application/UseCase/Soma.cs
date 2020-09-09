using Calculadora.Api.Controllers.Interfaces;
using System;
using System.Collections.Generic;


namespace Calculadora.Application.UseCase
{
    public class Soma : ISomaUseCase
    {
        public double Handler(List<double> lista)
        {
            var resultado = 0.0;

            foreach(var item in lista)
            {
                resultado = resultado + item;
            }

            return resultado;
        }
    }
}
