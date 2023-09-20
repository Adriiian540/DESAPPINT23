public class Cliente{

    public string Nombre {get;set;}
    public string RFC {get;set;}
    public string Domicilio{get;set;}
    public string Correo{get;set;}
    public double Total {get;set;}

    public List<Venta> Ventas {get;set;}

    public Cliente() {}
    public Cliente(string nombre,string rfc,string domicilio,string correo,double total,List<Venta> ventas)=>(Nombre,RFC,Domicilio,Correo,Total,Ventas) = (nombre,rfc,domicilio,correo,total,ventas);

}