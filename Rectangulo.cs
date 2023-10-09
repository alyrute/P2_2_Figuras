using System.Drawing;

namespace P2_2_Figuras;
   public class Rectangulo : Figura
{
    private double baseRectangulo;
    private double alturaRectangulo;

    public Rectangulo(double baseRectangulo, double alturaRectangulo, Color color)
        : base(color)
    {
        this.baseRectangulo = baseRectangulo;
        this.alturaRectangulo = alturaRectangulo;
    }

    public double BaseRectangulo
    {
        get { return baseRectangulo; }
        set { baseRectangulo = value; }
    }

    public double AlturaRectangulo
    {
        get { return alturaRectangulo; }
        set { alturaRectangulo = value; }
    }

    public override double GetArea()
    {
        return baseRectangulo * alturaRectangulo;
    }

    public override string ToString()
    {
        return "Rectangulo: \n" +
               $"Base: {BaseRectangulo}\n" +
               $"Altura: {AlturaRectangulo}\n" +
               base.ToString() +
               $"Área: {GetArea()}\n";
    }
}