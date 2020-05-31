using System.Collections.Generic;
using CHO.Entity;

namespace CHO.Data.Interfaces
{
  public interface IClientRepository
  {
    //CRUD
    Client GetClientById(int clientId);
    List<Client> GetClientList();
    Client AddClient(Client client);
    Client UpdateClient(Client client);
    Client DeleteClient(int clientId);

  }
}