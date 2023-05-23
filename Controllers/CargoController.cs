//atributos para los controles
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]

public class CargoController: ControllerBase
{

        ICargoService cargoService;
    public CargoController(ICargoService serviceCargo) => cargoService = serviceCargo;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostCargos([FromBody] Cargo newCargo) {
    await cargoService.Create(newCargo);
    var result = newCargo.CargoId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult GetCargo() {

return Ok(cargoService.Read());
}

//Update
[HttpPut("{id}")]
public IActionResult UpdateCargoes([FromBody] Cargo cargoActualizar, Guid id) {
    cargoService.Update(id,cargoActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteCargoes(Guid id) {
return Ok(cargoService.Delete(id));
}
}