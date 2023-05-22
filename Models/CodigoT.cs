
using System;
using System.ComponentModel.DataAnnotations;

public class CodigoT{

[Key]
public Guid CodigoTId{get;set;} = Guid.NewGuid();

[Required]
public int Antiguiedad {get;set;}
[Required]
public int DiasO{get;set;}
[Required]
public Boolean Vigente{get;set;}
}