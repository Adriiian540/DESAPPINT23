public class Academia{

    public string Nombre {get;set;}
    public string Propietario {get;set;}
    public string Domicilio {get;set;}

    public List<Categoria> Categorias {get; private set;} //private impide que desde otro codigo se le de acceso  
    
    //Constructor Vacio

    public Academia() => Categorias = new List<Categoria>();
    public Academia(string nombre,string propietario,string domicilio) : this() => (Nombre,Propietario,Domicilio) = (nombre,propietario,domicilio);

    public void AgregarCategoria(Categoria categoria) => Categorias.Add(categoria);

    public double SubTotalCategorias(){
        double total=0;
        foreach(Categoria categoria in Categorias)
                total = total + categoria.Jugadores.Count();
                return total;
    }
/*FALSO
       public double SubTotal(){
        double total=0;
        foreach(Categoria categoria in Categorias)
            total = total + categoria.Costo;
            return total;
   }*/
    public override string ToString()=> $"Nombre: {Nombre}\n Propietario: {Propietario}\nDomicilio: {Domicilio}";

    
}
