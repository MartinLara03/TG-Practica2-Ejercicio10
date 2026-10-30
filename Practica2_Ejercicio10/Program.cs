using System;

class Program
{
    static void Main(string[] args)
    {
        // RECTANGULO
        Console.WriteLine(" RECTANGULO ");

        Console.Write("Ingresa la base del rectangulo: ");
        double baseRectangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la altura del rectangulo: ");
        double alturaRectangulo = Convert.ToDouble(Console.ReadLine());

        Rectangulo rectangulo = new Rectangulo(alturaRectangulo, baseRectangulo);

        Console.WriteLine("Area del rectangulo: " + rectangulo.Area());


        // CIRCULO
        Console.WriteLine();
        Console.WriteLine(" CIRCULO ");

        Console.Write("Ingresa el radio del circulo: ");
        double radioCirculo = Convert.ToDouble(Console.ReadLine());

        Circulo circulo = new Circulo(radioCirculo);

        Console.WriteLine("Area del circulo: " + circulo.Area().ToString("F2"));


        // TRIANGULO
        Console.WriteLine();
        Console.WriteLine(" TRIANGULO ");

        Console.Write("Ingresa la base del triangulo: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la altura del triangulo: ");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        Triangulo triangulo = new Triangulo(alturaTriangulo, baseTriangulo);

        Console.WriteLine("Area del triangulo: " + triangulo.Area());


        // Evita que la consola se cierre
        Console.WriteLine();
        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();
    }
}