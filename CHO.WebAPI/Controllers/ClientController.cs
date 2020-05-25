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

    [HttpGet("{id}")]
    public IActionResult GetClient(int id)
    {
      if (id > dataArray.Length || id <= 0)
      {
        return BadRequest("Böyle bir ID bulunamadı");
      }

      return Ok(dataArray[id - 1]);
    }
  }
}
