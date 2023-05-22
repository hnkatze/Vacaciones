using Microsoft.EntityFrameworkCore;


public class Context:DbContext {
public DbSet<Cargo> Cargos {get;set;}
public DbSet<Empleado> Empleados {get;set;}
public DbSet<Vacas> Vacas {get;set;}
public DbSet<CodigoT> CodigoTs {get;set;}

public Context(DbContextOptions<Context> options) : base(options){}

}