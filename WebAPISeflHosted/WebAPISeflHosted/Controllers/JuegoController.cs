using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml;
using WebAPISeflHosted.Helpers;
using WebAPISeflHosted.Models;

namespace WebAPISeflHosted.Controllers
{
    public class JuegoController:ApiController
    {
        //Get Posiciones
        [HttpGet]
        public IHttpActionResult GetPocision(string id)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc = XmlHelper.CargaXml("Juego");
            return Ok(XmlHelper.BuscarValor(xmlDoc, id));
        }

        [HttpGet]
        public IHttpActionResult GetInicio()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc = XmlHelper.CargaXml("Juego");

            return Ok(xmlDoc);

        }

        //Post iniciar Juego.xml
        [HttpPost]
        public IHttpActionResult PostJugada(Comando Com)
        {
            if(Com.Comand == "Jugada") {
                try
                {
                    XmlHelper.MoverFicha(Com.coordenada1, Com.coordenada2);
                }
                catch(ArgumentException Ex)
                {
                    throw Ex;
                }
                return Ok(XmlHelper.CargaXml("Juego").DocumentElement);
            }
            else
            {
                return Ok("Funcion No Implementada");
            }
        }

        [HttpPost]
        public IHttpActionResult PostFin()
        {
            return Ok("Juego Terminado");
        }
    }
}
