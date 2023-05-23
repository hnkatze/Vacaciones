public class EmpleadoService: IEmpleadoService
{
//Inyeccion de dependencias
Context context;
public EmpleadoService(Context DbContext) => context = DbContext;
//CRUD

//Create
public async Task Create(Empleado newempleado)
{
    await context.AddAsync(newempleado);
    await context.SaveChangesAsync();
}

//Read
public IEnumerable<Empleado> Read( )=> context.Empleados;

//Update
public async Task Update(Guid id, Empleado empleado){
    var glo = context.Empleados.Find(id);
    if(glo != null){
        glo.Nombre = empleado.Nombre;
        glo.FechaIngreso = empleado.FechaIngreso;
        glo.Disponible = empleado.Disponible;
        await context.SaveChangesAsync();}}
//Delete
public async Task Delete(Guid id)
{
    var glo = context.Empleados.Find(id);
    if(glo != null)
    {
        context.Remove(id);
        await context.SaveChangesAsync();
    }
}

}

public interface IEmpleadoService
{
    Task Create(Empleado newempleado);
    IEnumerable<Empleado> Read();
    Task Update(Guid id, Empleado empleado);
    Task Delete(Guid id);


}