// Procesa n calificaciones, introducidas por el usuario, calcula suma y el promedio

int n = 0, c = 0;
float cal = 0, suma = 0, promedio = 0, promgral = 0;
string status = "";

char resp;

do {
    Console.Clear();
    promedio = suma = n = 0;
    Console.WriteLine("Procesa calificaciones del semestre agosto diciembre 2023\n\n PARA TERMINAR DE REGISTRAR UTILIZA 999\n");
    do {
    
        Console.Write("Calificacion ? "); cal = float.Parse(Console.ReadLine());
        if (cal != 999) {
            suma += cal;
            n++;
        }
    } while (cal != 999);
    promedio = suma / n;
    status = promedio >= 6 ? "Aprobado" : "Reprobado";
    Console.WriteLine($"La suma de las calificaciones es {suma}");
    Console.WriteLine($"El promedio es {promedio:f2}");
    Console.WriteLine($"Tu estatus es de {status}");
    c ++;
    promgral += promedio;
    Console.WriteLine("\n Deseas capturar las calificaciones de otro estudiante (S/N) ?");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');

promgral /= c;

Console.WriteLine($"Se procesaron las calificaciones de {c} estudiantes");
Console.WriteLine($"Promedio general de la clase {promgral}");