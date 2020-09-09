using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Application.Interfaces
{
    public interface IDivisaoUseCase
    {
        double Handler (List<double> inicio);
    }
}
