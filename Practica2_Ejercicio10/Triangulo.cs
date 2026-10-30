using Practica2_Ejercicio10;

public class Triangulo : IForma
{
    public double Altura;
    public double Base;

    public Triangulo(double altura, double baseTriangulo)
    {
        Altura = altura;
        Base = baseTriangulo;
    }

    public double Area()
    {
        return (Base * Altura) / 2;
    }
}