using Practica2_Ejercicio10;

public class Circulo : IForma
{
    public double Radio;

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public double Area()
    {
        return Math.PI * Radio * Radio;
    }
}