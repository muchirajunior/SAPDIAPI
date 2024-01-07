using Microsoft.AspNetCore.Mvc;

namespace SAPAPI.Controllers;
[ApiController]
[Route("")]
public class HomeController : ControllerBase{
    private SAPServerConnection connection;
    public HomeController(){
        this.connection=new SAPServerConnection();
    }
    [HttpGet("")]
    public IActionResult Index(){
       
        connection.ConnectToSAP();
        return Ok();
    }
  
    [HttpGet("error")]
    public IActionResult Error(){
        return BadRequest();
    }
}