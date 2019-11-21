using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;


namespace Entidades
{
    public delegate void Delegado(string mensaje);
    public class LosHilos : IRespuesta<int>
    {
        int id;
        List<InfoHilo> misHilos;
        public event Delegado AvisoFin;


        public string Bitacora
        {
            get
            {
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
                StreamReader sr = new StreamReader("Bitacora.txt");
                string retorno = sr.ReadToEnd();
                sr.Close();
                return retorno;
            }
            set
            {
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                using (StreamWriter sw = new StreamWriter("Bitacora.txt", true))
                {
                    sw.Write(value);
                }
            }
        }
        public LosHilos()
        {
            misHilos = new List<InfoHilo>();
            this.id = 0;
        }

        private LosHilos AgregarHilo(LosHilos hilos)
        {
            hilos.id ++;
            hilos.misHilos.Add(new InfoHilo(this.id,this));
            this.RespuestaHilo(hilos.id);
            return hilos;
        }

        public void RespuestaHilo(int id)
        {
            string mensaje = "Termino el hilo {0}.";
            this.Bitacora = mensaje;
            this.AvisoFin.Invoke(mensaje);
        }

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad < 1)
            {
                throw new CantidadInvalidaExeption();
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    hilos.AgregarHilo(hilos);
                }
            }
            return hilos;
        }
    }
}
