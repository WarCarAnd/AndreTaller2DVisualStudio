using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Circulo
    {
        private float r;
        public Circulo(float r)
        {
            this.r = r;
        }

            public float CalculateArea()
        {
            return (3.14f*(r*r));
        }
    }
    
}
