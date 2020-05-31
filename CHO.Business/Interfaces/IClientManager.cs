using CHO.DTO;

namespace CHO.Business.Interfaces
{
  public interface IClientManager
  {
    void AddClient(ClientAddRequestModelDTO addRequestModelDto);
    void UpdateClient(ClientUpdateRequestModelDTO updateRequestModelDto);
    void GetClientById(ClientGetRequestModelDTO clientGetRequestModelDto);
    void GetClientList();
    void DeleteClientById(ClientDeleteRequestModelDTO clientDeleteRequestModelDto);
  }
}