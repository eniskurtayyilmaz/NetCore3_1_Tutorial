using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CHO.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CHO.WebAPI.Controllers
{
  [Route("api/client")]
  [ApiController]
  public class ClientController : ControllerBase
  {
    private static ArrayList dataArray = new ArrayList()
    {
      "Müşteri 1", "Müşteri 2", "Müşteri 3", "Müşteri 4"
    };


    [HttpGet(Name = "GetClientList")]
    public IActionResult GetClientList()
    {
      return Ok(dataArray);
    }

    [HttpGet("{id}", Name = "GetClient")]
    public IActionResult GetClient(int id)
    {
      if (id > dataArray.Count || id <= 0)
      {
        return BadRequest("Böyle bir ID bulunamadı");
      }

      return Ok(dataArray[id - 1]);
    }

    [HttpPost(Name = "AddClient")]
    public IActionResult AddClient([FromBody]AddClientRequestModel model)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState.Values);
      }

      dataArray.Add(model.ClientName);

      return CreatedAtRoute("GetClient", new { id = dataArray.Count }, model);
    }

    [HttpPut("{id}", Name = "UpdateClient")]
    public IActionResult UpdateClient(int id, [FromBody] UpdateClientRequestModel model)
    {
      if (id > dataArray.Count || id <= 0)
      {
        return BadRequest("Böyle bir ID bulunamadı");
      }

      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState.Values);
      }

      dataArray[id - 1] = model.ClientName;

      return CreatedAtRoute("GetClient", new { id = id }, model);
    }



    [HttpDelete("{id}")]
    public IActionResult DeleteClient(int id)
    {
      if (id > dataArray.Count || id <= 0)
      {
        return BadRequest("Böyle bir ID bulunamadı");
      }

      dataArray.RemoveAt(id - 1);

      return Ok();
    }
  }
}
