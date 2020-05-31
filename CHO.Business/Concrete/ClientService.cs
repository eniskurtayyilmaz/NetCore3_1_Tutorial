using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHO.Business.Interfaces;
using CHO.DTO;
using CHO.DTO.Client.Response;

namespace CHO.Business.Concrete
{
  public class ClientService : IClientManager
  {

    private static ArrayList dataArray = new ArrayList()
    {
      "Müşteri 1", "Müşteri 2", "Müşteri 3", "Müşteri 4"
    };


    public ClientGetResponseModelDTO AddClient(ClientAddRequestModelDTO addRequestModelDto)
    {
      if (string.IsNullOrEmpty(addRequestModelDto?.ClientName))
      {
        return null;
      }

      dataArray.Add(addRequestModelDto.ClientName);
      return new ClientGetResponseModelDTO()
      {
        ClientId = dataArray.Count,
        ClientName = addRequestModelDto.ClientName
      };
    }

    public ClientGetResponseModelDTO UpdateClient(ClientUpdateRequestModelDTO updateRequestModelDto)
    {
      throw new NotImplementedException();
    }

    public ClientGetResponseModelDTO GetClientById(ClientGetRequestModelDTO clientGetRequestModelDto)
    {
      throw new NotImplementedException();
    }

    public List<ClientGetResponseModelDTO> GetClientList()
    {
      List<ClientGetResponseModelDTO> response = new List<ClientGetResponseModelDTO>();

      for (int i = 0; i < dataArray.Count; i++)
      {
        response.Add(new ClientGetResponseModelDTO()
        {
          ClientId = i + 1,
          ClientName = dataArray[i].ToString(),
        });
      }

      return response;
    }

    public ClientDeleteResponseModelDTO DeleteClientById(ClientDeleteRequestModelDTO clientDeleteRequestModelDto)
    {
      throw new NotImplementedException();
    }
  }
}
