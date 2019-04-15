using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDamas
{
    public class ObjComando
    {
        public string Comand { get; set; }
        public string coordenada1 { get; set; }
        public string coordenada2 { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://10.166.143.76:8000/";
            HttpClient client = new HttpClient();

            ObjComando obj = new ObjComando() {Comand= "Iniciar" };
            var stringContent = new StringContent(JsonConvert.SerializeObject(obj),
                Encoding.UTF8, "application/json");

            var response = client.PostAsync(baseAddress+"/api/Juego/", stringContent).Result;
            //Console.ReadKey();
        }
    }
}
