using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        float area = 0;
        float perimetro = 0;
        Punto Vertice1;
        Punto Vertice2;
        Punto Vertice3;
        Punto Vertice4;


        public Rectangulo(Punto Vertice1, Punto Vertice3)
        {
            this.perimetro = 0;
            this.area = 0;

            this.Vertice1 = Vertice1;
            Punto aux = new Punto(Vertice3.GetX(), Vertice1.GetY());
            this.Vertice2 = aux;
            this.Vertice3 = Vertice3;
            aux = new Punto(Vertice1.GetX(), Vertice3.GetY());
            this.Vertice4 = aux;


           // DistanciaPuntos = Math.Sqrt(Math.Pow(CatetoX, 2) + Math.Pow(CatetoY, 2));
        }

        public float GetArea()
        {
            if (this.area == 0)
            {
                float Base = this.Vertice3.GetX() - this.Vertice1.GetX();
                float Altura = this.Vertice3.GetY() - this.Vertice1.GetY();
                this.area = Base * Altura;
                return this.area;
            }
            else
            {
                return this.area;
            }
            
        }

        public float GetPerimetro()
        {
            if (this.perimetro == 0)
            {
                float Base = this.Vertice3.GetX() - this.Vertice1.GetX();
                float Altura = this.Vertice3.GetY() - this.Vertice1.GetY();
                this.perimetro = (Base + Altura)*2;
                return this.perimetro;
            }
            else
            {
                return this.perimetro;
            }

        }
    }
}
