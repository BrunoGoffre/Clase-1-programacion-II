
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        float x;
        float y;

        public float GetX()
        {
            return this.x;
        }
        public float GetY()
        {
            return this.y;
        }

        public Punto (float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
