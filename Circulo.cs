namespace P2_2_Figuras;
internal class Circulo : Figura{
    protected double _radio;

    public Circulo (double radio){
        _radio = radio;

    }

    public override double GetArea()
    {
        return Math.PI*(this._radio*this._radio);
    }

    public override string ToString()
    {
        return $" La base del circulo es: { _radio}";
    }
}