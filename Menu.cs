using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Menu
    {
        public void Execute()

        {
            Console.WriteLine("Cual figura quieres operar: ¿Triangulo, Rectangulo o Circulo?");       
            if (Console.ReadLine() == "Triangulo")
            {
                float b;
                float h;
                Console.WriteLine("Introduce la base");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduce la altura");
                h = float.Parse(Console.ReadLine());
                Triangle t = new Triangle(b, h);
                Console.WriteLine($"El área es {t.CalculateArea()}");
            }
            if (Console.ReadLine() == "Rectangulo")
            {
                float bas;
                ; float altura;
                Console.WriteLine("Introduce la base");
                bas = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduce la altura");
                altura = float.Parse(Console.ReadLine());
                Rectangulo r = new Rectangulo(bas, altura);
                Console.WriteLine($"El área es {r.CalculateArea()}");
            }
            if (Console.ReadLine() == "Circulo")
            {
                float C;
                Console.WriteLine("Introduce el radio");
                C = float.Parse(Console.ReadLine());
                Circulo R = new Circulo(C);
                Console.WriteLine($"El área es {R.CalculateArea()}");
            }

        }
    }
}
