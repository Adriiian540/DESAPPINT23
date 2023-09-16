// Calcula la paga de un trabajador, considerando las horas extra

//Inicializamos 
string nombre = ""; 
int horas = 0, hextra = 0;
float paga = 0, pagaextra= 0, pagabruta = 0, paganeta = 0, impuesto = 0, tasa = 0;

Console.Clear();
Console.WriteLine("Calculando la paga de un trabajador \n");
Console.Write("Nombre ? "); nombre = Console.ReadLine();
Console.Write("Horas  ? "); horas = int.Parse(Console.ReadLine());
Console.Write("Paga   ? "); paga = float.Parse(Console.ReadLine());

//Operaciones
tasa = 0.03f;

if(horas > 40) {
    hextra = horas - 40;
    pagaextra = 2 * paga * hextra;
    pagabruta = 40 * paga + pagaextra;
}else
    pagabruta = horas * paga;

impuesto = pagabruta * tasa;
paganeta = pagabruta - impuesto;

//Impresion
Console.WriteLine($"\nResumen de pagos del trabajador {nombre} \n");
Console.WriteLine($"{horas} horas trabajadas, {hextra} extra, paga {paga} tasa de impuesto {tasa:p2}");
Console.WriteLine($"paga bruta: {pagabruta,12:c2}");
Console.WriteLine($"paga extra: {pagaextra,12:c2}");
Console.WriteLine($"impuesto: {impuesto,12:c2}");
Console.WriteLine($"paga neta: {paganeta,12:c2}");