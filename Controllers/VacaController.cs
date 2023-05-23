//atributos para los controles
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]

public class VacaController: ControllerBase
{

        IVacaService vacaService;
    public VacaController(IVacaService serviceVaca) => vacaService = serviceVaca;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostVacas([FromBody] Vaca newVaca) {
    await vacaService.Create(newVaca);
    var result = newVaca.VacaId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult GetVaca() {

return Ok(vacaService.Read());
}

//Update
[HttpPut("{id}")]
public IActionResult UpdateVacaes([FromBody] Vaca vacaActualizar, Guid id) {
    vacaService.Update(id,vacaActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteVacaes(Guid id) {
return Ok(vacaService.Delete(id));
}
}