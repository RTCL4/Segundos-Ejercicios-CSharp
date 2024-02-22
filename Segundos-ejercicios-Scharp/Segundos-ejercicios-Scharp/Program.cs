//SENTENCIA IF Y ELSE
//EJERCICIO  1
Console.WriteLine("Ingrese un número\n");
//Optimo -> para ejecutar en VScode¿ int numero = int.Parse(Console.ReadLine());
int numero = int.Parse(Console.ReadLine()!);

if (numero < 0)
{
    Console.WriteLine("El número es negativo (no hay que ser negativo en la vida");
}

else if (numero > 0)
{
    Console.WriteLine("El número es positivo");
}

else
{
    Console.WriteLine("El número es cero");
}

//SENTENCIA IF, ELSE IF, ELSE
//IF ANIDADOS
//EJERCICIO 2
//Notar lo importante de llevar un orden de secuencias
Console.WriteLine("\nIngrese su año de nacimiento: \n");
int año1 = int.Parse(Console.ReadLine()!); //Y

if (año1 >= 1928 && año1 <= 1945)
{
    Console.WriteLine("Usted pertenece a la generación silenciosa");
}

else if (año1 >= 1946 && año1 <= 1964)
{
    Console.WriteLine("Usted pertenece a la generación de los baby boomers");
}
else if (año1 >= 1965 && año1 <= 1980)
{
    Console.WriteLine("Ustede pertenece a la generacion X");
}
else if (año1 >= 1981 && año1 <= 1996)
{
    Console.WriteLine("Usted pertenece a la generacion de los millenials");
}
else if (año1 >= 1997 && año1 <= 2012)
{
    Console.WriteLine("Usted pertenece a la generacion Z");
}
else if (año1 >= 2013)
{
    Console.WriteLine("Usted pertenece a la generación Alfa");
}

else
{
    Console.WriteLine("Año invalido");
}

//SWICH
//Ejercicio 3 - usando switch

Console.WriteLine("\nIngrese su año de nacimiento");
int año2;
año2 = int.Parse(Console.ReadLine()!);
switch (año2)
{
    case >= 1928 and <= 1945:
        Console.WriteLine("Usted pertenece a la generacion silenciosa");
        break;
    case >= 1946 and <= 1964:
        Console.WriteLine("Usted pertenece a la generacion de los baby boomers");
        break;
    case >= 1965 and <= 1980:
        Console.WriteLine("Usted pertenece a la generacion X");
        break;
    case >= 1981 and <= 1996:
        Console.WriteLine("Usted pertenece a la generacion millenials");
        break;
    case >= 1997 and <= 2012:
        Console.WriteLine("Usted pertenece a la generacion Z");
        break;
    case >= 2013:
        Console.WriteLine("Usted pertenece a la generacion Alfa");
        break;

    default:
        Console.WriteLine("Año invalido");
        break;
}

//SWICH
//Ejercicio 4 - Usando StartsWith y otras cositas

String nombre, pais;
int edad;
char genero;
Console.WriteLine("Ingrese su nombre");
nombre = Console.ReadLine()!.ToUpper();

Console.WriteLine("Ingrese pais: ");
pais = Console.ReadLine()!.ToUpper();

Console.WriteLine("Ingrese edad: ");
edad = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Ingrese genero: (M o F)");
genero = char.Parse(Console.ReadLine()!.ToUpper());

if (nombre.StartsWith('K') && (edad >= 18  || genero >='F')
    && (pais == "GUATEMALA" || pais == "MEXICO")){
    Console.WriteLine("Ud. cumple con los requisitos");
    }
else{
    Console.WriteLine("No admitido");
    }

Console.WriteLine($"\nEl nombre ingresado fue:{nombre}\nEl pais ingresado fue: {pais} \nEl genero ingresado fue: {genero}");
