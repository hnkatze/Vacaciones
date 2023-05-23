
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cargo{
[Key]
public Guid CargoId{get;set;}
[Required]
public String Nombre{get;set;}
// [NotMapped]
// public virtual ICollection<Empleado> empleado{get;set;}
}

