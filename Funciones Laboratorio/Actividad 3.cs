Console.WriteLine("ingrese el radio en cm de su circulo");
ImprimirResultado("resultado es: ", CalcularAreaCirculo(double.Parse(Console.ReadLine())));
static double CalcularAreaCirculo(double radio)
{
    double area = 3.1416 * radio * radio;
    return area;
}
static void ImprimirResultado(string resultado, double area)
{
    Console.WriteLine($"---{resultado}{area}---");
}