using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraApi.Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraApi.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaController : ControllerBase
    {

        [HttpPost]
        public ActionResult<Calcula> Post([FromBodyAttribute] Calcula calcula)
        {
            var c = new Calcula();
            c.Numero1 = calcula.Numero1;
            c.Numero2 = calcula.Numero2;
            c.TipoOperacao = calcula.TipoOperacao;
            c.Resultado = calcula.Resultado;
            c.Calculado(c);
            return c;
           
        }
    }
}