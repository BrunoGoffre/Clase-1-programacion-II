using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Interfaces;

namespace Entidades
{
    public class InfoHilo
    {
        IRespuesta<int> callBack;
        Thread hilo;
        int id;
        static Random randomizer;

        private void Ejecutar()
        {
            System.Threading.Thread.Sleep(randomizer.Next(1, 5));
            callBack.RespuestaHilo(this.id);
        }
        static InfoHilo()
        {
           randomizer = new Random();
        }
        private InfoHilo()
        {
            this.hilo = new Thread(Ejecutar);
        }
        public InfoHilo(int id, IRespuesta<int> callBack) : this()
        {
            this.id = id;
            this.callBack = callBack;
        }


    }
}
