using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CHO.WebAPI.Controllers
{
  [Route("api/client")]
  [ApiController]
  public class ClientController : ControllerBase
  {
    private static string[] dataArray = new string[4]
    {
      "Müşteri 1", "Müşteri 2", "Müşteri 3", "Müşteri 4"
    };


    [HttpGet]
    public IActionResult GetClientList()
    {
      return Ok(dataArray);
    }
  }
}
