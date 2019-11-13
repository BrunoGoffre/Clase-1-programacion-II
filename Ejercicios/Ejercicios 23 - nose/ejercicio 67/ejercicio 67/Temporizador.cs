using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ejercicio_67
{
    public delegate void EncargadoTiempo();
    class Temporizador
    {
        int intervalo;
        Thread hilo;
        public event EncargadoTiempo EventoTiempo;

        public Temporizador()
        {
            //hilo = new Thread(Corriendo);
        }
        public bool Activo
        {
            get
            {
                return hilo.IsAlive;
            }
            set
            {
                //if (value == false && hilo.IsAlive == false)
                //{
                //    hilo.Start();
                //}
                if (value == true)
                {
                    hilo = new Thread(Corriendo); //Variante para boton parar/reanudar
                    hilo.Start();
                }
                else
                {
                    hilo.Abort();
                }
            }
        }
        public int Intervalo
        {
            get
            {
                return intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        private void Corriendo()
        {
            do
            {
                EventoTiempo.Invoke();
                System.Threading.Thread.Sleep(intervalo);
            } while (true);
        }
    }
}
