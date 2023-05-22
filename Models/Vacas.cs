
using System.ComponentModel.DataAnnotations;

public class Vacas{
[Key]
public Guid VacacionesId{get;set;}= Guid.NewGuid();
[Required]
public String Fecha{get;set;}


}