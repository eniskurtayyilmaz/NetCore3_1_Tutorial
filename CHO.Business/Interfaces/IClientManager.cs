using System.Collections.Generic;
using CHO.DTO;
using CHO.DTO.Client.Response;

namespace CHO.Business.Interfaces
{
  public interface IClientManager
  {
    ClientGetResponseModelDTO AddClient(ClientAddRequestModelDTO addRequestModelDto);
    ClientGetResponseModelDTO UpdateClient(ClientUpdateRequestModelDTO updateRequestModelDto);
    ClientGetResponseModelDTO GetClientById(ClientGetRequestModelDTO clientGetRequestModelDto);
    List<ClientGetResponseModelDTO> GetClientList();
    ClientDeleteResponseModelDTO DeleteClientById(ClientDeleteRequestModelDTO clientDeleteRequestModelDto);
  }
}