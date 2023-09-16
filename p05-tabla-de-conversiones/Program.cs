// Imprime una tabla de conversion de peso a otras monedas

int ini= 0, fin=0, c=0;
float tcd = 17.70f, tcl = 21.21f, tce = 18.19f, tca = 0.048f;

Console.Clear();
Console.WriteLine("Imprime tabla de conversion de monedas\n");

do {
    Console.WriteLine("Inicio en Pesos Mex (Ingresa el inicio del valor del rango)  :"); ini = int.Parse(Console.ReadLine());
    Console.WriteLine("Fin en Pesos Mex (Ingresa el final del valor del rango)       :"); fin = int.Parse(Console.ReadLine());
} while(fin < ini); //valida que ini < fin

c = ini;
Console .WriteLine("Peso\tDolar\tLibra\tEuro\tArg");
Console .WriteLine(new string ('-',40));
while(c<=fin) {
    Console.WriteLine($"{c:f2}\t{c/tcd:f2}\t{c/tcl:f2}\t{c/tce:f2}\t{c/tca:f2}");
    c++;
}
Console .WriteLine(new string ('-',40));