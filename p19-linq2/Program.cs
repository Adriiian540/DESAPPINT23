﻿List<double> califs = new() {9.5,8.5,10.0,7.4,6.5,8.2,9.7,5.0,2.0,3.5};

Console.Clear();

Console.Write("Las calificaciones: "+ califs.Count()+":");
califs.ForEach(cal=>Console.Write(cal + " "));

var apr = califs.Where(cal=>cal>=6.5);
Console.WriteLine("\nAprobados: "+ apr.Count());
var rep = from cal in califs where cal<=6.4 select cal;
Console.WriteLine("\nReprobados: "+ rep.Count());

Console.WriteLine($"La suma{califs.Sum():f2} El promedio es{califs.Average():f2}");
Console.WriteLine($"El mayor es {califs.Max():f2}, El menor es {califs.Min():f2}");

var mayp = (from cal in califs where cal > califs.Average() select cal).ToList();
Console.WriteLine("\nMayores al promedio " + mayp.Count());
mayp.ForEach(cal=>Console.WriteLine(cal));

var menp = califs.Where(cal=>cal < califs.Average()).ToList();
Console.WriteLine("\nMenores al promedio: "+menp.Count());
menp.ForEach(cal=>Console.WriteLine(cal));

Console.WriteLine("Ordenar Lista Ascendente");
var ord1 = (from cal in califs orderby cal ascending select cal).ToList();
ord1.ForEach(cal=> Console.WriteLine(cal));

Console.WriteLine("Ordenar Lista Descendente");
var ord2 = (from cal in califs orderby cal descending select cal).ToList();
ord1.ForEach(cal=> Console.WriteLine(cal));

Console.WriteLine("Ordenar Lista Ascendente");
var ord3 = califs.OrderBy(c=>c).ToList();
ord3.ForEach(cal=> Console.WriteLine(cal));

Console.WriteLine("Ordenar Lista Descendente");
var ord4 = califs.OrderByDescending(c=>c).ToList();
ord4.ForEach(cal=> Console.WriteLine(cal));

