//Control empleados

//instanciar y reservar espacio en memoria para un objeto de una clase determinada

Empleado empleado01 = new Empleado();

empleado01.Nombre = "Juan Carlos";
empleado01.Edad = 22;
empleado01.Sexo = 'M';
empleado01.Casado = false;

empleado01.ImprirDatos();

//Instanciar, luego reservar espacio en memoria para un objeto de una clase determinada
Empleado empleado02;
empleado02 = new Empleado();
empleado02.Nombre = "Maria de Jesus";
empleado02.Edad = 41;
empleado02.Sexo = 'H';
empleado02.Casado = true;

empleado02.ImprirDatos();

Empleado empleado03 = new Empleado ("Claudia S", 35, 'M', false);
empleado03.ImprirDatos();

Empleado empleado04 = new Empleado {Nombre = "AMLO", Edad=75, Sexo = 'H', Casado = true};
empleado04.ImprirDatos();
