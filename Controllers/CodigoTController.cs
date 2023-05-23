//atributos para los controles
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]

public class CodigoTController: ControllerBase
{

        ICodigoTService codigoTService;
    public CodigoTController(ICodigoTService serviceCodigoT) => codigoTService = serviceCodigoT;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostCodigoTs([FromBody] CodigoT newCodigoT) {
    await codigoTService.Create(newCodigoT);
    var result = newCodigoT.CodigoTId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult GetCodigoT() {

return Ok(codigoTService.Read());
}

//Update
[HttpPut("{id}")]
public IActionResult UpdateCodigoTes([FromBody] CodigoT codigoTActualizar, Guid id) {
    codigoTService.Update(id,codigoTActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteCodigoTes(Guid id) {
return Ok(codigoTService.Delete(id));
}
}