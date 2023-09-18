// biblioteca de funciones estadisticas para un arreglo de numeros flotantes

public  class fun {

public int suma {get; set;}
public int rest {get; set;}
public double sumaDiv {get; set;}
public int[] Arreglo = {100, 123, 456, 222, 999, 895, 325, 234, 322, 988};

    public static void Imprimir (int[] Arreglo){
        for (int i = 0; i < Arreglo.Length; i++) {
        Console.WriteLine($"numero {i + 1}: {Arreglo[i]}");
    }
}
        public static double sum (int[] Arreglo){
        int suma = 0;
        for (int i = 0; i < Arreglo.Length; i++) {
        suma = suma + Arreglo[i];
    }
    return suma;
    }
    public static double sumDiv(int[] Arreglo){
        double rest = 0,sumaDivision = 0;
        for (int i = 0; i < Arreglo.Length; i++) {
        rest = Arreglo[i] / 2;
        sumaDivision = sumaDivision + rest;
}
    return sumaDivision;
    }

    public static void inverso(int[] Arreglo){
        for (int i = Arreglo.Length - 1; i >= 0; i--) {
            Console.WriteLine($"numero {i}: {Arreglo[i]}");
        }
    }

}