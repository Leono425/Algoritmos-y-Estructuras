Console.WriteLine("Para pasar de Celsius a Fahrenheit escriba 1");
Console.WriteLine("Para pasar de Fahrenheit a Celsius escriba 2");
int opcion = int.Parse(Console.ReadLine());
switch (opcion)
{
    case 1:
        Console.WriteLine("Ingrese la temperatura en Celsius");
        CelsiusAFahrenheit(int.Parse(Console.ReadLine()));
        break;
    case 2:
        Console.WriteLine("Ingrese la temperatura en Fahrenheit");
        FahrenheitACelsius(int.Parse(Console.ReadLine()));
        break;
}
double CelsiusAFahrenheit(double GradosC)
{
    double CelsiusAFahrenheit = (GradosC * 1.8) + 32;
    Console.WriteLine($"{CelsiusAFahrenheit}°F");
    return CelsiusAFahrenheit;
}
double FahrenheitACelsius(double GradosF)
{
    double FahrenheitACelsius = (GradosF - 32) / 1.8;
    Console.WriteLine($"{FahrenheitACelsius}°C");
    return FahrenheitACelsius;
}