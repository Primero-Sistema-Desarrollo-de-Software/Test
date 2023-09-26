Console.WriteLine("Ingrese el Primer Numero");
float Num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el Segundo Numero");
float Num2 = float.Parse(Console.ReadLine());

int OPcion = 0;

Console.WriteLine("Seleccione una opcion");

Console.WriteLine("Sumar");
Console.WriteLine("Restar");
Console.WriteLine("Multiplicar");
Console.WriteLine("Dividir");
OPcion = int.Parse(Console.ReadLine());
do
{
    switch (OPcion)
    {
        case 1:
            Console.WriteLine("Sumar");
            Sumar(Num1, Num2);

            break;

        case 2:
            break;

        case 3:
            break;

        case 4:
            break;

        default:
            Console.WriteLine("Operador no válido.");
            break;
    }
} while (OPcion != 5);

static void Sumar(float n1, float n2)
{
    float Suma = n1 + n2;
    Console.WriteLine("La Suma es: {☺}", Suma);
}

static void Restar(float n1, float n2)
{
    float Resta = n1 - n2;
    Console.WriteLine("La Resta es: {☺}", Resta);
}

static void Multiplicar(float n1, float n2)
{
    float Multiplicacion = n1 * n2;
    Console.WriteLine("El Resultado es: {☺}", Multiplicacion);
}

static void Dividir(float n1, float n2)
{
    float Division = n1 + n2;
    Console.WriteLine("EL Resultado es: {☺}", Division);
}

