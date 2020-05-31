using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using CHO.Data.Interfaces;
using CHO.Entity;

namespace CHO.Data.Concretes
{
  public class ClientRepository : IClientRepository
  {

    private static ArrayList dataArray = new ArrayList()
    {
      "Müşteri 1", "Müşteri 2", "Müşteri 3", "Müşteri 4"
    };


    public Client GetClientById(int clientId)
    {
      return new Client()
      {
        ID = clientId - 1,
        NAME = dataArray[clientId - 1].ToString(),
      };
    }

    public List<Client> GetClientList()
    {
      List<Client> response = new List<Client>();

      for (int i = 0; i < dataArray.Count; i++)
      {
        response.Add(new Client()
        {
          ID = i + 1,
          NAME = dataArray[i].ToString(),
        });
      }

      return response;
    }

    public Client AddClient(Client client)
    {
      dataArray.Add(client.NAME);

      return new Client()
      {
        ID = dataArray.Count,
        NAME = dataArray[dataArray.Count - 1].ToString(),
      };
    }

    public Client UpdateClient(Client client)
    {
      throw new NotImplementedException();
    }

    public Client DeleteClient(int clientId)
    {
      throw new NotImplementedException();
    }
  }
}
