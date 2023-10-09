using System.Drawing;

namespace P2_2_Figuras;
public class TrianguloEquilatero : Figura
{
    private double longitudLado;

    public TrianguloEquilatero(double longitudLado, Color color)
        : base(color)
    {
        this.longitudLado = longitudLado;
    }

    public double LongitudLado
    {
        get { return longitudLado; }
        set { longitudLado = value; }
    }

    public override double GetArea()
    {
        return (Math.Sqrt(3) / 4) * longitudLado * longitudLado;
    }

    public override string ToString()
    {
        return "Triangulo: \n" +
               $"Lado: {LongitudLado}\n" +
               base.ToString() +
               $"Área: {GetArea()}\n";
    }
}