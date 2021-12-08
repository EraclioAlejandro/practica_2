using System;
namespace Alcohol.Domain.Interface
{
    public interface ICalcularAlcohol
    {
         void Alcoholconsumido(string bebida, int cantidad);
         void PasaAlasangre(int peso);
    
          String Resultado();
    }
}