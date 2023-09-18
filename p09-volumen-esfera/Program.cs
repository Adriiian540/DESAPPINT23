// Dado el radio de un círculo, calcula el volumen de la esfera

double PI = 3.14159;
double r = 0;
double v = 0;

Console.Write("Introduce el radio del circulo: "); r = double.Parse(Console.ReadLine());

v = (4.0/3.0)*(Math.Pow(r,3))*(PI);

Console.WriteLine($"El volumen es: {v}");