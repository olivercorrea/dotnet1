// See https://aka.ms/new-console-template for more information
static double AreaTriangulo(double x1, double y1, double x2, double y2, double x3, double y3)
{
    double area = 0.5 * ((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));

    if (area < 0)
    {
        area = area * (-1);
    }
    return area;
}

static void Main(string[] args)
{
    Console.Title = "Superficie de un triangulo dada las coordenadas de sus vertices";
    Console.WriteLine("Superficie de un triangulo dada las coordenadas de sus vertices");
    Console.WriteLine("---------------------------------------------------------------");

    Console.Write("Ingrese x1: ");
    double x1 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese y1: ");
    double y1 = double.Parse(Console.ReadLine());

    Console.WriteLine("--------------");
    Console.Write("Ingrese x2: ");
    double x2 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese y2: ");
    double y2 = double.Parse(Console.ReadLine());

    Console.WriteLine("--------------");
    Console.Write("Ingrese x3: ");
    double x3 = double.Parse(Console.ReadLine());
    Console.Write("Ingrese y3: ");
    double y3 = double.Parse(Console.ReadLine());

    Console.WriteLine("---------------------------------------------------------------");
    double area = AreaTriangulo(x1, y1, x2, y2, x3, y3);
    Console.WriteLine($"El área del triángulo es: {area}");
}

Main(args);
