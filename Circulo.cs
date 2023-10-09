using System.Drawing;

namespace P2_2_Figuras;
public class Circulo : Figura
{
    private double radio;

    public Circulo(double radio, Color color)
        : base(color)
    {
        this.radio = radio;
    }

    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }

    public override double GetArea()
    {
        return Math.PI * radio * radio;
    }

    public override string ToString()
    {
        return "Circulo: \n" +
               $"Radio: {Radio}\n" +
               base.ToString() +
               $"Área: {GetArea()}\n";
    }
}