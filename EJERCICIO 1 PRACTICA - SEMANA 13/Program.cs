﻿
byte opcion;

string regresar;

do
{

    Console.WriteLine("DESAYUNOS DEL MES\n");

    Console.WriteLine("******* MENÚ *******");

    Console.WriteLine("* 1. Crear   *");

    Console.WriteLine("* 2. Listar  *");

    Console.WriteLine("* 3. Eliminar *");

    Console.WriteLine("* 0. Fin      *");

    Console.WriteLine("********************\n");



    Console.Write("Ingrese opcion: ");



    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 4)
    {

        Console.Write("Error: Ingrese opcion: ");

    }



    switch (opcion)
    {

        case 0: Environment.Exit(0); break;

        case 1: break;

        case 2: break;

        case 3: break;


    }

    Console.WriteLine("Desea regresar al menú? [si]: ");

    regresar = Console.ReadLine();

    Console.Clear();

} while (regresar == "si");























