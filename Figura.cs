using System;
using System.Drawing;

// Clase abstracta para representar figuras geométricas
public abstract class Figura
{
    protected Color color;

    public Figura(Color color)
    {
        this.color = color;
    }

    public abstract double GetArea();

    public override string ToString()
    {
        return $"Color: {color}\n";
    }
}