//necesario para usar la estructura Color
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color?view=net-7.0
using System.Drawing;
//método para obtener un color a partir de los valores RGBA 
// https://learn.microsoft.com/es-es/dotnet/api/system.drawing.color.fromargb?view=net-7.0

namespace P2_2_Figuras;

public class P2_2_Figuras
{
  static void Main(string[] args)
  {
            //Asignamos el color, me he vuelto loca para poner asi los colores
            Color color1 = Color.FromArgb(255, 50, 20, 34);
            Rectangulo rectangulo = new Rectangulo(3.0, 3.9, color1);

            Color color2 = Color.FromArgb(255, 0, 20, 35);
            Circulo circulo = new Circulo(4.0, color2);

           Color color3 = Color.FromArgb(255, 0, 20, 40);
            TrianguloEquilatero triangulo = new TrianguloEquilatero(3.0, color3);

          
        

            Console.WriteLine(rectangulo.ToString());
            Console.WriteLine($"Area del rectangulo: {rectangulo.GetArea()}");

            Console.WriteLine(circulo.ToString());
            Console.WriteLine($"Area del circulo: {circulo.GetArea()}");

            Console.WriteLine(triangulo.ToString());
            Console.WriteLine($"Area del triangulo equilatero: {triangulo.GetArea()}");

            //Modifico algunos parametros
            rectangulo.BaseRectangulo = 4.0;
            circulo.Radio = 5.0;
            triangulo.LongitudLado = 4.0;

            Console.WriteLine("\n**DESPUES DE MODIFICAR***:");

            Console.WriteLine(rectangulo.ToString());
            Console.WriteLine($"Area del rectangulo: {rectangulo.GetArea()}");

            Console.WriteLine(circulo.ToString());
            Console.WriteLine($"Área del circulo: {circulo.GetArea()}");

            Console.WriteLine(triangulo.ToString());
            Console.WriteLine($"Área del triangulo equilátero: {triangulo.GetArea()}");


    
           
        }
    }


