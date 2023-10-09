namespace P2_2_Figuras;
internal class Rectangulo : Figura{
    protected double _radio;

    public Rectangulo (double radio){
        _radio = radio;

    }

    public override double GetArea()
    {
        return Math.PI*(this._radio*this._radio);
    }
}