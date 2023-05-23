
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Vaca{
[Key]
public Guid VacaId{get;set;}= Guid.NewGuid();
[Required]
public String Fecha{get;set;}

[ForeignKey("EmpleadoId")]
public Guid EmpleadoId{get;set;}

public virtual Empleado empleado{get;set;}

}