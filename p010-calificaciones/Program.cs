// Emitir una calificación con letra y un mensaje de acuerdo al promedio, según la tabla

double calificacion = 0;

Console.Write("Escribe tu nombre: \n"); string nombre = Console.ReadLine();

//do {
    Console.WriteLine ("Escribe una calificacion entre 0 y 10\n");
    Console.Write("Introduce tu calificación: "); calificacion = Convert.ToDouble(Console.ReadLine());

switch(calificacion)
{
    case <= 5.9: 
        tabla(nombre);
        Console.WriteLine($"{calificacion}\t\tD\tAndas mal");
         break;
    case <= 7.5 : 
        tabla(nombre);
        Console.WriteLine($"{calificacion}\t\tC\tMucho mejor");
        break;
    case <= 8.5 : 
        tabla(nombre);
        Console.WriteLine($"{calificacion}\t\tB\tMuy bien");
        break;
    default:
        tabla(nombre);
        Console.WriteLine($"{calificacion}\t\tA\tExelente"); 
        break;
}


static void tabla(string nombre) {
        Console.WriteLine($"Alumno: {nombre}");
        Console.WriteLine("Promedio\tLetra\tMensaje");
}