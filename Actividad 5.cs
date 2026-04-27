using System.Security.Cryptography.X509Certificates;
/**El Sistema de Cajero:**

Crea un programa para un cajero automático que contenga:

1.Un método `void` para mostrar el menú.
2. Una función que reciba el saldo actual y el monto a retirar, y **retorne** el nuevo saldo (validando que haya fondos).
3.Un método que use un parámetro `out` para devolver al mismo tiempo: si la operación fue exitosa (`bool`) y cuántos billetes se entregaron (`int`).
*/
int saldo = 0;

Console.WriteLine($"Tu saldo actual es de {saldo}");
Console.WriteLine("Selecione 2 para ingresar dinero");
Console.WriteLine("Selecione 3 para sacar dinero");
Console.WriteLine("");

menu(int.Parse(Console.ReadLine()), ref saldo);

static void retiror(ref int saldo, int retirar, out bool retiro)
{
    Console.WriteLine("");
    if (saldo < retirar || retirar < 0)
    {
        retiro = false;
    }
    else
    {
        retiro = true;
    }
    if (retiro == false)
    {
        Console.WriteLine("La operacion fallo");
        Console.WriteLine("");
    }
    else
    {
        saldo = saldo - retirar;
        Console.WriteLine($"Se retiro {retirar}");
    }
}
static void menu(int opcion, ref int saldo)
{

    switch (opcion)
    {
        case 1:
            Console.WriteLine("");
            Console.WriteLine($"Tu saldo actual es de {saldo}");
            Console.WriteLine("Selecione 2 para ingresar dinero");
            Console.WriteLine("Selecione 3 para sacar dinero");
            Console.WriteLine("");
            menu(int.Parse(Console.ReadLine()), ref saldo);
            break;

        case 2:
            Console.WriteLine("");
            Console.WriteLine("Cuanto dinero quieres ingresar");
            int ingreso = int.Parse(Console.ReadLine());
            saldo = saldo + ingreso;
            break;
        case 3:
            Console.WriteLine("Cuanto dinero quieres retirar");
            retiror(ref saldo, int.Parse(Console.ReadLine()), out bool retiro);
            break;

        default:
            break;
    }
    ;
    Console.WriteLine("Quieres volver al menu? Y/N");
    char respuesta = char.Parse(Console.ReadLine());
    if (respuesta == 'Y')
    {
        menu(1, ref saldo);
    }
    else
    {

    }

}