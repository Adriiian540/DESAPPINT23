//crea un programa para calcular datos de un arreglo
int suma = 0;
int rest = 0;
double sumaDiv = 0;
int[] Arreglo = {100, 123, 456, 222, 999, 895, 325, 234, 322, 988};
int opcion;

Console.Clear();

    Console.WriteLine("MENU");
    Console.WriteLine("1. Mostrar Arreglo");
    Console.WriteLine("2. Suma de elementos");
    Console.WriteLine("3. Division de elementos");
    Console.WriteLine("4. Orden inverso");
    Console.WriteLine("5. Todo lo anterior");
    Console.Write("Seleccione una opción (1 - 5): ");

    opcion = int.Parse(Console.ReadLine());

     switch(opcion)
            {
                case 1:
                fun.Imprimir(Arreglo);
                break;
                case 2:
                Console.WriteLine($"La suma es: {fun.sum(Arreglo)}");;
                break;
                case 3:
                Console.WriteLine($"La suma con division es: {fun.sumDiv(Arreglo)}");
                break;
                case 4:
                fun.inverso(Arreglo);
                break;
                case 5:
                fun.inverso(Arreglo);
                Console.WriteLine($"La suma es: {fun.sum(Arreglo)}");;
                Console.WriteLine($"La suma con division es: {fun.sumDiv(Arreglo)}");
                fun.inverso(Arreglo);
                break;
                default:
                Console.WriteLine("Seleccione una opción correcta.");
                break;

            }





    