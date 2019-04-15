using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using WebAPISeflHosted.Models;

namespace WebAPISeflHosted.Helpers
{
    public static class XmlHelper
    {
        public static XmlDocument CargaXml(string ruta)
        {
            Console.WriteLine("Send Tablero ");
            DirectoryInfo di = new DirectoryInfo(@"C:\temp\CursoWebAPI\");
            FileInfo[] TXTFiles = di.GetFiles(ruta+".xml");
            XmlDocument xmlRegresa = new XmlDocument();
            Console.WriteLine("C:\\temp\\CursoWebAPI\\"+ruta+".xml");
            string[] cadenaid = new string[] {"A","B","C","D","E","F","G","H" };
            if (TXTFiles.Length == 0)
            {
                //Crear xml 
                XmlDeclaration xmlDeclaration = xmlRegresa.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = xmlRegresa.DocumentElement;
                xmlRegresa.InsertBefore(xmlDeclaration, root);
                XmlElement element1 = xmlRegresa.CreateElement(string.Empty, "body", string.Empty);
                xmlRegresa.AppendChild(element1);

                for (int cont = 0; cont < 8; cont++)
                {
                    XmlElement Renglon = xmlRegresa.CreateElement(string.Empty, cadenaid[cont], string.Empty);
                    element1.AppendChild(Renglon);
                    for (int count2 = 0; count2 < 8; count2++)
                    {
                        if (cadenaid[cont] == "A" || cadenaid[cont] == "H")
                        {
                            XmlElement celda = xmlRegresa.CreateElement(string.Empty, "C" + Convert.ToString(count2), string.Empty);
                            if ((count2 % 2) == 0)
                            {
                                XmlText textif = xmlRegresa.CreateTextNode("1");
                                celda.AppendChild(textif);
                                Renglon.AppendChild(celda);
                            }
                            else { 
                            XmlText text2 = xmlRegresa.CreateTextNode("0");
                            celda.AppendChild(text2);
                            Renglon.AppendChild(celda);
                            }
                        }
                        else if (cadenaid[cont] == "B" || cadenaid[cont] == "G")
                        {
                            XmlElement celda = xmlRegresa.CreateElement(string.Empty, "C" + Convert.ToString(count2), string.Empty);
                            if ((count2 % 2) == 0)
                            {
                                XmlText textif = xmlRegresa.CreateTextNode("0");
                                celda.AppendChild(textif);
                                Renglon.AppendChild(celda);
                            }
                            else
                            {
                                XmlText text2 = xmlRegresa.CreateTextNode("1");
                                celda.AppendChild(text2);
                                Renglon.AppendChild(celda);
                            }
                        }
                        else
                        {
                            XmlElement celda = xmlRegresa.CreateElement(string.Empty, "C" + Convert.ToString(count2), string.Empty);
                            XmlText text2 = xmlRegresa.CreateTextNode("0");
                            celda.AppendChild(text2);
                            Renglon.AppendChild(celda);
                        }
                        
                    }

                }
                xmlRegresa.Save(@"C:\temp\CursoWebAPI\" + ruta + ".xml");


            }
            else {
                xmlRegresa.Load(@"C:\temp\CursoWebAPI\"+ruta+".xml");
            }
            
            return xmlRegresa;
        }
        /// <summary> 
        /// Funciones Damas chinas
        /// </summary>
        /// <param name="xdoc Documento de Xml que ingresa"></param>
        /// <param name="posicion A buscar"></param>
        /// <returns></returns>
        public static int BuscarValor(XmlDocument xdoc, string posicion)
        {
            Console.WriteLine("Valido Valores ");
            string nodo = posicion.Substring(0, 1);
            string col = "C"+posicion.Substring(1, 1);
            int res = 5;

            foreach (XmlNode n in xdoc.SelectNodes("/body"))
            {
                foreach(XmlNode x in n)
                {
                    if (x.Name == nodo)
                    {
                        foreach (XmlNode val in x)
                        {
                            if(val.Name == col)
                            {
                                res = Convert.ToInt32(val.InnerText);
                            }
                        }
                        
                    }
                }

                
            }
            return res;
        }

        public static bool MoverFicha(string pocisionOri, string pocisionFin)
        {
            Console.WriteLine("Movimiento de ficha"+ pocisionOri +" A "+ pocisionFin);
            bool Validator = true;

            string nodo = pocisionOri.Substring(0, 1);
            string col = "C" + pocisionOri.Substring(1, 1);

            string nodofin = pocisionFin.Substring(0, 1);
            string colfin = "C" + pocisionFin.Substring(1, 1);

            XmlDocument xmldoc = new XmlDocument();
            xmldoc = CargaXml("Juego");

            if (BuscarValor(xmldoc, pocisionOri) == 1 && BuscarValor(xmldoc, pocisionFin) == 0)
            {
                foreach (XmlNode n in xmldoc.SelectNodes("/body"))
                {
                    foreach (XmlNode x in n)
                    {
                        if (x.Name == nodo || x.Name == nodofin)
                        {
                            foreach (XmlNode val in x)
                            {
                                if (val.Name == col && x.Name == nodo)
                                {
                                    val.InnerText = "0";
                                }
                                if (val.Name == colfin && x.Name == nodofin)
                                {
                                    val.InnerText = "1";
                                }
                            }

                        }
                    }
                }
                xmldoc.Save(@"C:\temp\CursoWebAPI\Juego.xml");
            }
            else Validator = false;

            return Validator;
        }
        
        //-----------------------------------------------------------------------
        public static List<Persona> CargaListaFromXml(XmlDocument xdoc)
        {
            List<Persona> lstRegresa = new List<Models.Persona>();
            Persona p = new Persona();
            foreach (XmlNode n in xdoc.SelectNodes("/Personas/Persona"))
            {
                p = new Persona();
                p.id = n.SelectSingleNode("id").InnerText;
                p.nombre = n.SelectSingleNode("nombre").InnerText;
                p.email = n.SelectSingleNode("email").InnerText;
                lstRegresa.Add(p);
            }
            return lstRegresa;
        }

        public static void GuardaXmlFromLista(List<Persona> lstPersonas, string ruta)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.AppendChild(xDoc.CreateElement("Personas"));
            foreach(Persona p in lstPersonas)
            {
                XmlElement elem = xDoc.CreateElement("Persona");
                elem.AppendChild(xDoc.CreateElement("id")).InnerText = p.id;
                elem.AppendChild(xDoc.CreateElement("nombre")).InnerText = p.nombre;
                elem.AppendChild(xDoc.CreateElement("email")).InnerText = p.email;
                xDoc.DocumentElement.AppendChild(elem);
            }
            xDoc.Save(ruta);
        }
    }
}