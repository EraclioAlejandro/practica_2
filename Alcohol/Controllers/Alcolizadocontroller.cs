using Alcohol.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Alcohol.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class Alcolizadocontroller : ControllerBase
    {
        [HttpGet]
        [Route("Calcular")]
        
        public IActionResult CalcularAlcohol(string _bebida,int cantidad, int peso)
        {
            
            var Alcohol = new Bebidas();
            Alcohol.Alcoholconsumido(_bebida,cantidad);
            if(_bebida.ToLower()!= "cerveza" && _bebida.ToLower()!="vino" && _bebida.ToLower()!="cava" &&_bebida.ToLower()!="vermu" && _bebida.ToLower()!="licor" && _bebida.ToLower()!="brandy")
            {
                return Ok("Error: La bebida que ingresada es incorrecta, intente nuevamente.");
            }
            Alcohol.PasaAlasangre(peso);
            if (peso <0)
            {
                return Ok("Error: El peso que ingresado es incorrecto, intente nuevamente.");
            }
            return Ok(Alcohol.Resultado());
        }
    }
}