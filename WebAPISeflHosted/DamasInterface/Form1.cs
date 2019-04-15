using DamasInterface.DataMannager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace DamasInterface
{
    
    public partial class InterFace : Form
    {
        string baseAddress = "http://10.166.143.54:8000/";
        HttpClient client = new HttpClient();

        public InterFace()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CargarXml(string Datos)
        {
            DG_res.Rows.Clear();
            string[] cadenaid = new string[10];
            int cont = 1;
            var details = JObject.Parse(Datos);

            foreach (JToken jToken in details.Property("body"))
            {
                foreach (JProperty Jp in jToken)//Renglon
                {
                    cadenaid[0] = Jp.Name;

                    foreach (JObject Jpp in Jp)
                    {
                        foreach (KeyValuePair<string, JToken> JJp in Jpp)//Valores
                        {
                            cadenaid[cont] = JJp.Value.ToString();
                            cont++;
                        }
                        DG_res.Rows.Add(cadenaid);
                        cont = 1;
                    }

                }

            }
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            Command obj = new Command() { Comand = "Iniciar" };

            var response =  client.GetAsync(baseAddress + "/api/Juego/GetInicio").Result;
            var convert = response.Content.ReadAsStringAsync().Result;
            CargarXml(convert);
        }

        private void Btn_Move_Click(object sender, EventArgs e)
        {
            WebAPISeflHosted.Helpers.XmlHelper.MoverFicha(Txb_Origin.Text, Txb_End.Text);

            Command obj = new Command() { Comand = "Jugada",
                                            coordenada1 = Txb_Origin.Text,
                                            coordenada2 = Txb_End.Text};


            var stringContent = new StringContent(JsonConvert.SerializeObject(obj),
                Encoding.UTF8, "application/json");

            var response = client.PostAsync(baseAddress + "/api/Juego/PostJugada", stringContent).Result;
            var convert = response.Content.ReadAsStringAsync().Result;
            CargarXml(convert);
        }

        private void Btn_End_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }

}
