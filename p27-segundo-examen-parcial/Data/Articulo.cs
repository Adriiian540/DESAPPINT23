using System.ComponentModel.DataAnnotations;
public class Articulo {
[Key]
public int Id {get; set;}

[Required]
[MinLength(3, ErrorMessage="Mínimo 3 dígitos"), MaxLength(25, ErrorMessage="Máximo 25 dígitos")]
public string Descripcion {get; set;}

[Required]
[Range(typeof(DateTime), "01/01/2000", "31/12/2024", ErrorMessage="Fecha fuera de rango de edad")]
public DateTime FechaAlta {get; set;}

[Required]
[Range(0,100)]
public int Cantidad {get; set;}

[Required]
[Range(0,2500)]
public double Precio {get; set;}

[Required]
//[RegularExpression("^(Metro|Litro|Kilo|Pieza|Caja)$",ErrorMessage = "Escoge algo correcto")]
public string UdeMedida {get; set;}



}