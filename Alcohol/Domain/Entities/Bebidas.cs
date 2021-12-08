using Alcohol.Domain.Interface;
using System;
namespace Alcohol.Domain.Entities
{
        
    public class Bebidas : ICalcularAlcohol
    {
         private double etanol = 0.789;
        private int _cantidad;
        private int _Cantidadliquido;
        private int _peso;
        private double totalconsumido;
        private double DirectoSangre;
        private double etanoensangre;
        private double volumenSangre;
        private double AlcholSangre;
        private double gradoAlcohol;
        private string _bebida;
        public void Alcoholconsumido(string bebida, int cantidad)
        {
            _cantidad = cantidad;
            _bebida = bebida.ToLower();
            switch (_bebida)
            {
                    case "cerveza":
                    _Cantidadliquido = 330;
                    _cantidad = _cantidad * _Cantidadliquido;
                    gradoAlcohol = 5;
                    totalconsumido = gradoAlcohol / 100 * _cantidad;
                    break;
                    case "vino": 
                    _Cantidadliquido = 100;
                    _cantidad = _cantidad * _Cantidadliquido;
                    gradoAlcohol = 12;
                    totalconsumido = gradoAlcohol / 100 * _cantidad;
                    break;
                    case "cava": 
                    _Cantidadliquido = 100;
                    _cantidad = _cantidad * _Cantidadliquido;
                    gradoAlcohol = 12;
                    totalconsumido = gradoAlcohol / 100 * _cantidad;
                    break;
                    case "vermu":
                    _Cantidadliquido = 70;
                    _cantidad = _cantidad * _Cantidadliquido;
                    gradoAlcohol = 17;
                    totalconsumido = gradoAlcohol / 100 * _cantidad;
                    break;
                    case "licor":
                    _Cantidadliquido = 45;
                    _cantidad = _cantidad * _Cantidadliquido;
                    gradoAlcohol = 23;
                    totalconsumido = gradoAlcohol / 100 * _cantidad;
                    break;
                    case "brandy":
                    _Cantidadliquido = 45;
                    _cantidad = _cantidad * _Cantidadliquido;
                    gradoAlcohol = 38;
                    totalconsumido = gradoAlcohol / 100 * _cantidad;
                    break;
                    case "combinado":
                    _Cantidadliquido = 50;
                    _cantidad = _cantidad * _Cantidadliquido;
                    gradoAlcohol = 38;
                    totalconsumido = gradoAlcohol / 100 * _cantidad;
                    break;
        }
        }
        public void PasaAlasangre(int peso)
        {
           _peso = peso;
           //CCalcular la cantidad de alcohol que pasa directo a la sangre
            DirectoSangre = 0.15 * totalconsumido;
          //7Calcular la masa del etanol en sangre
            etanoensangre = etanol * DirectoSangre;
        ///Calcular la masa del etanol en sangre
            volumenSangre = 0.8 * _peso;
        //Calcular el volumen de alcohol en la sangre (Alcoholemia) 
            AlcholSangre = etanoensangre / volumenSangre;
        
        }
        
        public string Resultado()
        {
                if (AlcholSangre >  0.8)
                {
                    return $" Su nivel de alcohol en la sangre es  de: {AlcholSangre}  Como podemos ver es superior al limite que nos ponen en el reglamento, no es apto para manejar";
                }
                    return $" Su nivel de alcohol en la sangre es  de: {AlcholSangre}  Como podemos ver no es superior al limite que nos ponen en el reglamento,  es apto para manejar, que tenga un buen viaje";
               
        }

        

        
    }
}