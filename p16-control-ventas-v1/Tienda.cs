using System.Net.WebSockets;

public class Tienda {
    public string Nombre {get;set;}
    public string Propietario {get;set;}
    public string Domicilio {get;set;}

    public List<Cliente> Clientes {get;set;}
/*
    public virtual double Compras(double Gastos){
        if()
    }
*/
    public void ImprimirDatos(){
        Console.WriteLine($"Nombre  :   {Nombre}");
        Console.WriteLine($"Propietario  :   {Propietario}");
        Console.WriteLine($"Domicilio  :   {Domicilio}");
    }

    public Tienda() => Clientes = new List<Cliente>();
    public void AgregarCliente(Cliente cliente) => Clientes.Add(cliente);



}