using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Rectangulo
    {
        private float bas;
        private float altura;
        public Rectangulo(float b, float h)
        {
            this.bas = b;
            this.altura = h;
        }
        public float CalculateArea()
        {
            return (bas * altura);
        }
    }
}
