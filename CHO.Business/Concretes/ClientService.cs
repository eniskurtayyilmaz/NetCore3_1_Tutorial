using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CHO.Business.Interfaces;
using CHO.Data.Concretes;
using CHO.Data.Interfaces;
using CHO.DTO;
using CHO.DTO.Client.Response;
using CHO.Entity;

namespace CHO.Business.Concrete
{
  public class ClientService : IClientManager
  {
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
      _clientRepository = clientRepository;
    }

    //public ClientService()
    //{
    //  _clientRepository = new ClientRepository();
    //}

    public ClientGetResponseModelDTO AddClient(ClientAddRequestModelDTO addRequestModelDto)
    {
      if (string.IsNullOrEmpty(addRequestModelDto?.ClientName))
      {
        return null;
      }

      var responseRepository = _clientRepository.AddClient(new Client()
      {
        ID = 0,
        NAME = addRequestModelDto.ClientName,
        EMAIL = "",
        ISDELETED = false,
      });

     

      return new ClientGetResponseModelDTO()
      {
        ClientId = responseRepository.ID,
        ClientName = responseRepository.NAME
      };
    }

    public ClientGetResponseModelDTO UpdateClient(ClientUpdateRequestModelDTO updateRequestModelDto)
    {
      throw new NotImplementedException();
    }

    public ClientGetResponseModelDTO GetClientById(ClientGetRequestModelDTO clientGetRequestModelDto)
    {
      var responseRepository = _clientRepository.GetClientById(clientGetRequestModelDto.ClientId);

      return new ClientGetResponseModelDTO()
      {
        ClientId = responseRepository.ID,
        ClientName = responseRepository.NAME
      };
    }

    public List<ClientGetResponseModelDTO> GetClientList()
    {
      List<ClientGetResponseModelDTO> response = new List<ClientGetResponseModelDTO>();

      var responseRepository = _clientRepository.GetClientList();

     

      return responseRepository.Select(x=> new ClientGetResponseModelDTO() {ClientId = x.ID, ClientName = x.NAME}).ToList();
    }

    public ClientDeleteResponseModelDTO DeleteClientById(ClientDeleteRequestModelDTO clientDeleteRequestModelDto)
    {
      throw new NotImplementedException();
    }
  }
}
