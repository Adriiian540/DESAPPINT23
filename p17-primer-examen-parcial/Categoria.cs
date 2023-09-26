public class Categoria{
    public string Nombre {get; set;}
    public string Rango {get; set;}
    public double Costo {get; set;}

    public List<Jugador> Jugadores {get;set;}
    public Categoria() => Jugadores = new List<Jugador>();
    public Categoria(string nombre,string rango, double costo) : this() => (Nombre,Rango,Costo) = (nombre,rango,costo);

    public void AgregarJugador(Jugador jugador) => Jugadores.Add(jugador);

    public double SubTotalSexM(){
        double total = 0;
        foreach(Jugador jugador in Jugadores)
           if (jugador.Sexo == 'M')
            total = total + 1;
        return total;
    }

     public double SubTotalSexF(){
        double total = 0;
        foreach(Jugador jugador in Jugadores)
           if (jugador.Sexo == 'F')
            total = total + jugador.Sexo;
        return total;
    }


    public override string ToString() => $"Nombre: {Nombre} Rango: {Rango} Costo: {Costo}";

}