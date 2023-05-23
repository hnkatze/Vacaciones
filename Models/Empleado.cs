
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Empleado{
[Key]
public Guid EmpleadoId{get;set;}=Guid.NewGuid();
[Required]
public String Nombre{get;set;}
[Required]
public String FechaIngreso{get;set;}
[Required]
public Boolean Disponible{get;set;}

[ForeignKey("CargoId")]
public Guid CargoId{get;set;}

public virtual Cargo cargo{get;set;}
}