public class VacaService: IVacaService
{
//Inyeccion de dependencias
Context context;
public VacaService(Context DbContext) => context = DbContext;
//CRUD

//Create
public async Task Create(Vaca newvaca)
{
    await context.AddAsync(newvaca);
    await context.SaveChangesAsync();
}

//Read
public IEnumerable<Vaca> Read( )=> context.Vacas;

//Update
public async Task Update(Guid id, Vaca vaca){
    var glo = context.Vacas.Find(id);
    if(glo != null){
        glo.Fecha = vaca.Fecha;
        await context.SaveChangesAsync();}}
//Delete
public async Task Delete(Guid id)
{
    var glo = context.Vacas.Find(id);
    if(glo != null)
    {
        context.Remove(id);
        await context.SaveChangesAsync();
    }
}

}

public interface IVacaService
{
    Task Create(Vaca newvaca);
    IEnumerable<Vaca> Read();
    Task Update(Guid id, Vaca vaca);
    Task Delete(Guid id);


}