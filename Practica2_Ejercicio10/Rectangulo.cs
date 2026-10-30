using Practica2_Ejercicio10;

public class Rectangulo : IForma
{
    public double Altura;
    public double Base;

    public Rectangulo(double altura, double baseRectangulo)
    {
        Altura = altura;
        Base = baseRectangulo;
    }

    public double Area()
    {
        return Base * Altura;
    }
}
