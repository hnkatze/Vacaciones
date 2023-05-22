public class CargoService: ICargoService
{
//Inyeccion de dependencias
Context context;
public CargoService(Context DbContext) => context = DbContext;
//CRUD

//Create
public async Task Create(Cargo newcargo)
{
    await context.AddAsync(newcargo);
    await context.SaveChangesAsync();
}

//Read
public IEnumerable<Cargo> Read( )=> context.Cargos;

//Update
public async Task Update(Guid id, Cargo cargo){
    var glo = context.Cargos.Find(id);
    if(glo != null){
        glo.Nombre = cargo.Nombre;
        await context.SaveChangesAsync();}}
//Delete
public async Task Delete(Guid id)
{
    var glo = context.Cargos.Find(id);
    if(glo != null)
    {
        context.Remove(id);
        await context.SaveChangesAsync();
    }
}

}

public interface ICargoService
{
    Task Create(Cargo newcargo);
    IEnumerable<Cargo> Read();
    Task Update(Guid id, Cargo cargo);
    Task Delete(Guid id);


}