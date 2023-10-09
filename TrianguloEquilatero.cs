using System.Drawing;

namespace P2_2_Figuras;
internal class TrianguloEquilatero : Figura{
    protected double _longitudLado;


    public TrianguloEquilatero (double longitudLado) {
        _longitudLado = longitudLado;

    }

    public override double GetArea()
    {
        return (Math.Sqrt(3) / 4) * _longitudLado * _longitudLado;
    }

    public override string ToString()
    {
        return $" La longitud{_longitudLado}";
    }

}