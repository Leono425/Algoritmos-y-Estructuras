Console.WriteLine("Ingrese su edad");
int edad = int.Parse(Console.ReadLine());

if (EsMayorDeEdad(edad) == true)
{
    Console.WriteLine("Es mayor de edad");
}
else
{
    Console.WriteLine("No es mayor de edad");
}

static bool EsMayorDeEdad(int edad)
{
    if (edad < 18)
    {
        bool EsMayorDeEdad = false;
        return EsMayorDeEdad;
    }
    else
    {
        bool EsMayorDeEdad = true;
        return EsMayorDeEdad;
    }
}