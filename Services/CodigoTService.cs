public class CodigoTService: ICodigoTService
{
//Inyeccion de dependencias
Context context;
public CodigoTService(Context DbContext) => context = DbContext;
//CRUD

//Create
public async Task Create(CodigoT newcodigoT)
{
    await context.AddAsync(newcodigoT);
    await context.SaveChangesAsync();
}

//Read
public IEnumerable<CodigoT> Read( )=> context.CodigoTs;

//Update
public async Task Update(Guid id, CodigoT codigoT){
    var glo = context.CodigoTs.Find(id);
    if(glo != null){
        glo.Antiguiedad = codigoT.Antiguiedad;
        glo.DiasO = codigoT.DiasO;
        glo.Vigente = codigoT.Vigente;
        await context.SaveChangesAsync();}}
//Delete
public async Task Delete(Guid id)
{
    var glo = context.CodigoTs.Find(id);
    if(glo != null)
    {
        context.Remove(id);
        await context.SaveChangesAsync();
    }
}

}

public interface ICodigoTService
{
    Task Create(CodigoT newcodigoT);
    IEnumerable<CodigoT> Read();
    Task Update(Guid id, CodigoT codigoT);
    Task Delete(Guid id);


}