
using System.ComponentModel.DataAnnotations;

public class Cargo{
[Key]
public Guid CargoId{get;set;}
[Required]
public String Nombre{get;set;}


}

