// Programa que envia un saludo en pantalla

string amigo = "Angel";
string hermano = "Carlos";

amigo="Osvaldo";

Console.WriteLine("Hola " + amigo);
Console.WriteLine($"Hola {amigo} bienvenido a c#");
Console.WriteLine($"\nMi amigo es {amigo} mi hermano es {hermano}");
Console.WriteLine("Nombres en mayusculas");
Console.WriteLine($"{amigo.ToUpper()}   {hermano.ToUpper()}");