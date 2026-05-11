Console.WriteLine("ingrese el numero 1");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese el numero 2");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese el numero 3");
double num3 = double.Parse(Console.ReadLine());
Console.WriteLine($"El numero mas alto es {ObtenerMaximo(num1, num2, num3)}");
double ObtenerMaximo(double num1, double num2, double num3)
{
    if (num1 > num2 && num1 > num3)
    {
        return num1;
    }
    else if (num2 > num1 && num2 > num3)
    {
        return num2;
    }
    else if (num3 > num1 && num3 > num2)
    {
        return num3;
    }
    else
    {
        return num1;
    }
}