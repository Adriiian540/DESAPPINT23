public class Jugador{
    public string Nombre {get; set;}
    public int AñoNac {get; set;}
    public char Sexo {get; set;}
    public bool Becado {get; set;}

    public Jugador() {}
    public Jugador(string nombre,int añoNac,char sexo,bool becado) => (Nombre,AñoNac,Sexo,Becado) = (nombre,AñoNac,Sexo,Becado);

    


    public override string ToString() => $"Nombre: {Nombre} AñoNac: {AñoNac} Sexo: {Sexo} {Becado}";

}