using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{


Context Dbcontext;


public HomeController(Context db){
Dbcontext = db;

}

[HttpGet]
[Route("ConnDB")]
public IActionResult ConnDB(){
Dbcontext.Database.EnsureCreated();
return Ok();

}
}