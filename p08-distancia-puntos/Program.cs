// Calcular la distancia entre dos puntos, dadas las coodenadas del punto A y el punto B

double Ax = 0, Ay = 0;
double Bx = 0, By = 0;
double distancia = 0;

Console.Write("Introduce la coordenada del punto A en x: "); Ax = double.Parse(Console.ReadLine());
Console.Write("Introduce la coordenada del punto A en y: "); Ay = double.Parse(Console.ReadLine());
Console.Write("Introduce la coordenada del punto B en x: "); Bx = double.Parse(Console.ReadLine());
Console.Write("Introduce la coordenada del punto B en y: "); By = double.Parse(Console.ReadLine());

distancia = Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2));

Console.WriteLine($"La distancia entre los puntos es: {distancia}");