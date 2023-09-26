Academia miacademia = new Academia {Nombre="Las poderosas Aguilas", Domicilio="Av. Pedro Coronel", Propietario="Adrian Robledo"};

//Agregar Categorias:

miacademia.AgregarCategoria(new Categoria {Nombre="Asquel",Rango="2015-2018",Costo=1000});
miacademia.AgregarCategoria(new Categoria {Nombre="Coyote",Rango="2010-2012",Costo=3000});
miacademia.AgregarCategoria(new Categoria {Nombre="Zorro",Rango="2008-2010",Costo=2000});

//Agregar ventas a los jugadores

miacademia.Categorias[0].AgregarJugador(new Jugador {Nombre = "Antonio Aguilar Alvarez", AñoNac = 2015, Sexo = 'M', Becado=true});
miacademia.Categorias[0].AgregarJugador(new Jugador {Nombre = "Osvaldo Badillo", AñoNac = 2016, Sexo = 'M', Becado=false});
miacademia.Categorias[0].AgregarJugador(new Jugador {Nombre = "Angel Sotelo", AñoNac = 2017, Sexo = 'M', Becado=true});

miacademia.Categorias[1].AgregarJugador(new Jugador {Nombre = "Kikidinho Juarez", AñoNac = 2010, Sexo = 'M', Becado=true});
miacademia.Categorias[1].AgregarJugador(new Jugador {Nombre = "Johan el kun", AñoNac = 2011, Sexo = 'M', Becado=false});
miacademia.Categorias[1].AgregarJugador(new Jugador {Nombre = "El pulpo shai", AñoNac = 2012, Sexo = 'M', Becado=true});

miacademia.Categorias[2].AgregarJugador(new Jugador {Nombre = "Sir Errox", AñoNac = 2008, Sexo = 'M', Becado=true});
miacademia.Categorias[2].AgregarJugador(new Jugador {Nombre = "Juan Pablo de Lara", AñoNac = 2009, Sexo = 'M', Becado=true});
miacademia.Categorias[2].AgregarJugador(new Jugador {Nombre = "El CUMpeon", AñoNac = 2010, Sexo = 'M', Becado=true});



//Reporte
Console.Clear();
Console.WriteLine("REPORTE DEL CLUB DEPORTIVO\n");
Console.WriteLine(miacademia.ToString());
Console.WriteLine($"\nTotal de Categorias: {miacademia.Categorias.Count()}");
foreach( Categoria categoria in miacademia.Categorias)
    Console.WriteLine($"\n- Jugadores Masculinos por categoria: {categoria.SubTotalSexM()}");
foreach( Categoria categoria in miacademia.Categorias)
    Console.WriteLine($"\n- Jugadores Femeninos por categoria: {categoria.SubTotalSexF()}");

Console.WriteLine("\n>> Datos generales de las Categorias\n");
foreach(Categoria categoria in miacademia.Categorias){                 
    Console.WriteLine(categoria.ToString());
}

Console.WriteLine("\n>> Jugadores de las categorias\n");
foreach( Categoria categoria in miacademia.Categorias){
    Console.WriteLine($">{categoria.Nombre} - ({categoria.Jugadores.Count()})\n");
    foreach(Jugador jugador in categoria.Jugadores)
        Console.WriteLine(jugador.ToString());
}