//atributos para los controles
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]

public class EmpleadoController: ControllerBase
{

        IEmpleadoService empleadoService;
    public EmpleadoController(IEmpleadoService serviceEmpleado) => empleadoService = serviceEmpleado;

    //atributos para los endpoint 

    //Create
    [HttpPost]
public async Task<IActionResult> PostEmpleados([FromBody] Empleado newEmpleado) {
    await empleadoService.Create(newEmpleado);
    var result = newEmpleado.EmpleadoId;
    if(result == null){
        return BadRequest();
    }
return Ok("Se ingreso Correctamente");

}
//Read
[HttpGet]
public IActionResult GetEmpleado() {

return Ok(empleadoService.Read());
}

//Update
[HttpPut("{id}")]
public IActionResult UpdateEmpleadoes([FromBody] Empleado empleadoActualizar, Guid id) {
    empleadoService.Update(id,empleadoActualizar);
return Ok("Actualizado Corretcamente");
}

//Delete
[HttpDelete("{id}")]

public IActionResult DeleteEmpleadoes(Guid id) {
return Ok(empleadoService.Delete(id));
}
}