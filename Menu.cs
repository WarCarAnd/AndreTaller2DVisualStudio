using System;
using System.Collections;
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
            bool available = false;
            while (!available)
            {
                Console.WriteLine("Cual figura quieres operar: ¿Triangulo, Rectangulo o Circulo?");
                string figure = Console.ReadLine();
                float b;
                float h;
                float bas;
                float altura;
                float C;
                switch (figure)
                {
                    case "Triangulo":

                        Console.WriteLine("Introduce la base");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura");
                        h = float.Parse(Console.ReadLine());
                        Triangle t = new Triangle(b, h);
                        Console.WriteLine($"El área es {t.CalculateArea()}");
                        available = true;
                        break;

                    case "Rectangulo":
                        Console.WriteLine("Introduce la base");
                        bas = float.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce la altura");
                        altura = float.Parse(Console.ReadLine());
                        Rectangulo r = new Rectangulo(bas, altura);
                        Console.WriteLine($"El área es {r.CalculateArea()}");
                        available = true;
                        break;

                    case "Circulo":
                        Console.WriteLine("Introduce el radio");
                        C = float.Parse(Console.ReadLine());
                        Circulo R = new Circulo(C);
                        Console.WriteLine($"El área es {R.CalculateArea()}");
                        available = true;
                        break;
                    default:
                        available = false;
                        Console.WriteLine("Puedes escribirlo denuevo");
                        break;
                }
            }
        }
    }
}       

        
    

