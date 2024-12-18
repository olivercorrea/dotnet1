//Función para calcular la suma de 2 números enteros
static int Suma(int a, int b)
{
    return a + b;
}
//Función para calcular la resta de 2 números enteros
static int Resta(int a, int b)
{
    return a - b;
}
//Función para calcular la multiplicación de 2 números enteros
static int Multiplicacion(int a, int b)
{
    return a * b;
}
//Función para calcular la division de 2 números enteros
static int Division(int a, int b)
{
    return a / b;
}
//Procedimiento que imprime la raíz cuadrada de los 10 primeros números
static void Raiz()
{
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
    }
}

// Función que imprime los 10 primeros números primos.
static void Primos()
{
    for (int i = 2; i <= 30; i++)
    {
        bool esPrimo = true;
        for (int j = 2; j <= Math.Sqrt(i); j++)
        {
            if (i % j == 0)
            {
                esPrimo = false;
                break;
            }
        }
        if (esPrimo)
        {
            Console.WriteLine(i);
        }
    }
}

// Función o procedimiento que permita realizar una conversión de temperatura.
static void Temperatura()
{
    Console.WriteLine("Ingrese la escala de conversión (C para Celsius, F para Fahrenheit)");
    string escala = Console.ReadLine().ToUpper();

    decimal gradosFahrenheit = 0;

    switch (escala)
    {
        case "C":
            Console.WriteLine("Ingrese la temperatura en grados Celsius");
            decimal gradosCelsius = Convert.ToDecimal(Console.ReadLine());
            gradosFahrenheit = (gradosCelsius * 9 / 5) + 32;
            Console.WriteLine("La temperatura en Fahrenheit es: {0}", gradosFahrenheit);
            break;
        case "F":
            Console.WriteLine("Ingrese la temperatura en grados Fahrenheit");
            gradosFahrenheit = Convert.ToDecimal(Console.ReadLine());
            gradosCelsius = (gradosFahrenheit - 32) * 5 / 9;
            Console.WriteLine("La temperatura en Celsius es: {0}", gradosCelsius);
            break;
    }
}

// Método main de la aplicación
static void Main(string[] args)
{
    Console.Title = "Procedimientos y funciones";
    string opcion;
    do
    {
        Console.Clear();
        Console.WriteLine("[1] Suma de dos números");
        Console.WriteLine("[2] Resta de dos números");
        Console.WriteLine("[3] Multiplicacion de dos números");
        Console.WriteLine("[4] Division de dos números");
        Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
        Console.WriteLine("[6] Imprimir los 10 primeros números primos");
        Console.WriteLine("[7] Conversión de temperatura");
        Console.WriteLine("[0] Salir");
        Console.WriteLine("Ingrese una opción y presione ENTER");

        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.WriteLine("Ingrese el primer número");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                Console.ReadKey();
                break;
            case "2":
                Console.WriteLine("Ingrese el primer número");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                int d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                Console.ReadKey();
                break;
            case "3":
                Console.WriteLine("Ingrese el primer número");
                int e = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                int f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El producto de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                Console.ReadKey();
                break;
            case "4":
                Console.WriteLine("Ingrese el primer número");
                int g = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                int h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El cociente de {0} y {1} es {2}", g, h, Division(g, h));
                Console.ReadKey();
                break;
            case "5":
                Console.WriteLine("Calculando...");
                Raiz();
                Console.ReadKey();
                break;
            case "6":
                Console.WriteLine("Calculando...");
                Primos();
                Console.ReadKey();
                break;
            case "7":
                Console.WriteLine("Calculando...");
                Temperatura();
                Console.ReadKey();
                break;
        }
    } while (!opcion.Equals("0"));
}

Main(args);