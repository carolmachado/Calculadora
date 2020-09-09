using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Api.Controllers.Interfaces
{
    public interface ISomaUseCase
    {
        double Handler(List<double> lista);
    }
}