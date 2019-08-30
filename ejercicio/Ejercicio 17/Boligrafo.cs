using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Boligrafo
    {
        public const short CantidadDeTintaMaxima = 100;
        ConsoleColor color;
        short tinta; 

        private ConsoleColor GetColor()
        {
            ConsoleColor Color;
            Color = this.color;
            return color;
        }

        private short GetTinta ()
        {
            short tinta;
            tinta = this.tinta;
            return tinta;
        }
        
        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if (this.tinta < 0)
            {
                this.tinta = 0;
            }
            else if (this.tinta > 100)
            {
                this.tinta = 100;
            }
        
            /*if (tinta < 0 && tinta >= -100)
            {
                this.tinta += tinta;
                if (this.tinta < 0)
                {
                    this.tinta = 0;
                }
            }
            else if (tinta > 0 && tinta <= 100)
            {
                    this.tinta += tinta;
                    if (this.tinta > 100)
                    {
                        this.tinta = 100;
                    }
            }     */       
        }
        
        public void recargar()
        {
            SetTinta(100);
        }

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";
            int aux = GetTinta();

            if (GetTinta() > 0)
            {
                SetTinta(gasto);
                aux -= GetTinta();
                for (int i = 0; i < aux; i++)
                {
                    dibujo += "*";
                }
                Console.ForegroundColor = color;
                retorno = true;
            }      

            return retorno;
        }
            
    }
}
