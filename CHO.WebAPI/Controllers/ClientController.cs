using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CHO.Business.Interfaces;
using CHO.DTO;
using CHO.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CHO.WebAPI.Controllers
{
  [Route("api/client")]
  [ApiController]
  public class ClientController : ControllerBase
  {
    private readonly IClientManager _clientManager;
    public ClientController(IClientManager clientManager)
    {
      _clientManager = clientManager;
    }


    [HttpGet(Name = "GetClientList")]
    public IActionResult GetClientList()
    {
      var responseBusiness = _clientManager.GetClientList();

      return Ok(responseBusiness);
    }

    [HttpGet("{id}", Name = "GetClient")]
    public IActionResult GetClient(int id)
    {
      //if (id > dataArray.Count || id <= 0)
      //{
      //  return BadRequest("Böyle bir ID bulunamadı");
      //}

      var responseBusiness = _clientManager.GetClientById(new ClientGetRequestModelDTO() {ClientId = id});


      return Ok(responseBusiness);
    }

    [HttpPost(Name = "AddClient")]
    public IActionResult AddClient([FromBody]AddClientRequestModel model)
    {
      //  if (!ModelState.IsValid)
      //  {
      //    return BadRequest(ModelState.Values);
      //  }

      //  dataArray.Add(model.ClientName);

      var responseBusiness = _clientManager.AddClient(new ClientAddRequestModelDTO() { ClientName = model.ClientName });

      return CreatedAtRoute("GetClient", new { id = responseBusiness.ClientId }, model);
    }

    [HttpPut("{id}", Name = "UpdateClient")]
    public IActionResult UpdateClient(int id, [FromBody] UpdateClientRequestModel model)
    {
      var responseBusiness = _clientManager.UpdateClient(new ClientUpdateRequestModelDTO()
      {
        ClientId = id,
        ClientName = model.ClientName
      });

      //TODO: hata dönüşümleri
      //if (id > dataArray.Count || id <= 0)
      //{
      //  return BadRequest("Böyle bir ID bulunamadı");
      //}

      //if (!ModelState.IsValid)
      //{
      //  return BadRequest(ModelState.Values);
      //}


      return CreatedAtRoute("GetClient", new { id = responseBusiness.ClientId }, responseBusiness);
    }



    [HttpDelete("{id}")]
    public IActionResult DeleteClient(int id)
    {
      //if (id > dataArray.Count || id <= 0)
      //{
      //  return BadRequest("Böyle bir ID bulunamadı");
      //}

      //dataArray.RemoveAt(id - 1);

      var responseBusiness = _clientManager.DeleteClientById(new ClientDeleteRequestModelDTO() {ClientId = id});
      
      return Ok(responseBusiness);
    }
  }
}
