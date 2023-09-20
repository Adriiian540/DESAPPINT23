Console.Clear();

Console.WriteLine("Reporte Final\n");

//Clase tienda
Tienda tienda1;
tienda1 = new Tienda();

tienda1.Nombre="Abarrotes don Pancho";
tienda1.Propietario="Don Pancho";
tienda1.Domicilio="C. Frontera # 228";

tienda1.ImprimirDatos();

//Clase Clientes
tienda1.AgregarCliente(new Cliente ("Adrian","SJ319DJAS4","C.Telegrafos #245","adrian@gmail.com",1200,new List<Venta>()));
tienda1.AgregarCliente(new Cliente ("Juan","DJAS8FS9ZGF","C.Lomas #312","Juan@gmail.com",2700,new List<Venta>()));
tienda1.AgregarCliente(new Cliente ("Mauro","LFIGS87345D","C.Guerrero #123","Mauro@gmail.com",1000,new List<Venta>()));


// Pasamos por cada cliente de los que hay en el Banco e imprimimos sus datos
foreach(Cliente cte in tienda1.Clientes) {
Console.WriteLine($"\nCliente : {cte.ToString()}, Ventas : {cte.Ventas.Count}");
foreach(Venta cta in cte.Ventas) {
Console.WriteLine($", Articulo/s: {cta.Articulo:n2}");
Console.WriteLine($", Cantidad: {cta.Cantidad:n2}");
Console.WriteLine($", Precio: {cta.Precio:n2}");    
    }
}