﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Proyecto
{
    [Serializable]
    public class Persona
    {
        public string nombre;
        public string apellido;
        
        public Persona()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public static void Guardar(Persona persona)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\xml";
             
            XmlTextWriter writer = new XmlTextWriter(path, null);
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
            ser.Serialize(writer, persona);

            writer.Close();
        }
        public static Persona Read(string path)
        {
            Persona aux;
            XmlTextReader reader = new XmlTextReader(path);
            XmlSerializer ser = new XmlSerializer(typeof(Persona));

            aux = (Persona)ser.Deserialize(reader);

            reader.Close();

            return aux;
        }

        public override string ToString()
        {
            return $"Nombre: {this.nombre} Apellido: {this.apellido}";
        }
    }
}
