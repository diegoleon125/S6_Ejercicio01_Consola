Console.Write("Ingrese un número máximo de personas: ");
int  max = int.Parse(Console.ReadLine());
Console.WriteLine("=========================================");
Console.Write("El número máximo establecido es de " + max + " personas,\r\n" +
    "presione una tecla para comenzar a contar _");
Console.ReadKey();

ConsoleKey opcion = ConsoleKey.Q;
int personas = 0;
int porcentaje = 0;
int ingresan = 0;
int salen = 0;
int lleno = 0;
int vacio = 0;
while (opcion != ConsoleKey.X)
{
    Console.Clear();
    Console.WriteLine("========================================");
    Console.WriteLine("| Asistentes actuales | " + personas);
    Console.WriteLine("| Aforo | " + porcentaje + "%");
    Console.WriteLine("| Máximo | " + max + " personas");
    Console.WriteLine("========================================");
    Console.WriteLine("Presione");
    Console.WriteLine("[ i ] si ingresa una persona ");
    Console.WriteLine("[ s ] si sale una persona");
    Console.Write("[ x ] para terminar _");
    opcion = Console.ReadKey().Key;
    if (opcion == ConsoleKey.I)
    {
        personas++;
        ingresan++;
    }
    if (opcion == ConsoleKey.S)
    {
        personas--;
        salen++;
    }
    if (personas == max)
    {
        lleno++;
    }
    if (personas == 0)
    {
        vacio++;
    }
    porcentaje = (personas * 100) / max;
}

Console.Clear();
Console.WriteLine("========================================");
Console.WriteLine("El programa ha terminado");
Console.WriteLine("========================================");
Console.WriteLine("Estadísticas:");
Console.WriteLine("----------------------------------");
Console.WriteLine(ingresan + " personas ingresaron");
Console.WriteLine(salen + " personas salieron");
Console.WriteLine(lleno + " veces se llenó el local");
Console.WriteLine("Estuvo vacío " + vacio + " veces");